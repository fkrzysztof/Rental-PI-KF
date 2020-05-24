// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

// Pie Chart Example

//dopisane
$(document).ready(function () {


    $.getJSON("/Statistics/GetData", function (data) {
        var Names = []
        var StatData = []

        var add = 100;

        for (var i = 0; i < data.length; i++) {
            Names.push(data[i].name);
            StatData.push(parseInt(((data[i].nameCount) / (data[i].all)) * 100));
        }

        for (var i = 0; i < StatData.length; i++) {
            add = add - StatData[i];
        }

        StatData.push(add);
        Names.push("Pozostałe marki");

        console.log(typeof StatData[1]);


        var ctx = document.getElementById("myPieChart");
        var myPieChart = new Chart(ctx, {
            type: 'doughnut',
            data: {
                //labels: ["Direct", "Referral", "Social"],
                labels: Names,
                datasets: [{
                    //data: [85, 10, 15],
                    data: StatData,
                    //Primary #4e73df, Success #1cc88a, Info #36b9cc, Warning #f6c23e, Danger #e74a3b, Secondary #858796
                    backgroundColor: ['#4e73df', '#1cc88a', '#36b9cc', '#f6c23e', '#e74a3b', '#EFEFEF'],
                    hoverBackgroundColor: ['#2e59d9', '#17a673', '#2c9faf', '#F6C211', '#E74A11', '#D2D2D2'], 
                    hoverBorderColor: "rgba(234, 236, 244, 1)",
                }],
            },
            options: {
                maintainAspectRatio: false,
                tooltips: {
                    backgroundColor: "rgb(255,255,255)",
                    bodyFontColor: "#858796",
                    borderColor: '#dddfeb',
                    borderWidth: 1,
                    xPadding: 15,
                    yPadding: 15,
                    displayColors: false,
                    caretPadding: 10,
                },
                legend: {
                    display: false
                },
                cutoutPercentage: 80,
            },
        });

    });
});