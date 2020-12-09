jQuery(document).ready(function() {


    restartForm();
    
    function restartForm()
    {
        $("#intervention_battery").hide();
        $("#intervention_column").hide();
        $("#intervention_elevator").hide();

    }

    $("#building_id").change(() => {

        $("#intervention_column").hide();
        $("#intervention_elevator").hide();

        if ($("#building_id").val() != "default") {

            $("#battery_id").prop("value", "default");
            $("#column_id").prop("value", "default");
            $("#elevator_id").prop("value", "default");
            $("#intervention_battery").show();
        }
    });

    $("#battery_id").change(() => {

        $("#intervention_elevator").hide();
        
        if ($("#battery_id").val() != "default") {

            $("#column_id").prop("value", "default");
            $("#elevator_id").prop("value", "default");
            $("#intervention_column").show();
        }
    });

    $("#column_id").change(() => {
        
        if ($("#column_id").val() != "default") {
            $("#elevator_id").prop("value", "default");
            $("#intervention_elevator").show();
        }
    });

    // -- SUBMIT FORM --
    $("#submit_intervention").submit(() => {
        
        // Send POST request through AJAX
        $.ajax({
            url: "https://rocket-elevators-api-rest.azurewebsites.net/api/intervention/submit",
            type: "POST",
            datatype: "json",
            data: {

                // Intervention data 
                customer_Id: $("customer_id").html,
                building_Id: $("building_id").html,
                battery_Id:  submit_intervention.battery_id.html,
                column_Id:   submit_intervention.column_id.html,
                elevator_Id: submit_intervention.elevator_id.html

            }
        });
    })





});