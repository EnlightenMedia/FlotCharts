

myApp.directive('chart', function () {
    return {
        restrict: 'EA',
        scope: {
            plotclick: '&plotclick',
            chart: '=ngModel',
        },
        link: function ($scope, elem, attrs) {


            var chart = null;

            $(elem).show();
            //$.plot(elem, $scope.data, $scope.opts);

            $(elem).bind("plotclick", function (event, pos, item) {
                $scope.plotclick({ item: item });
            });

            $("<div id='tooltip'></div>").css({
                position: "absolute",
                display: "none",
                border: "1px solid #fdd",
                padding: "2px",
                "background-color": "#fee",
                opacity: 0.80
            }).appendTo("body");

            function showTooltip(x, y, contents) {
                $('<div id="tooltip">' + contents + '</div>').css({
                    position: 'absolute',
                    display: 'none',
                    top: y + 5,
                    left: x + 5,
                    border: '1px solid #333',
                    padding: '2px',
                    size: '10',
                    'border-radius': '6px 6px 6px 6px',
                    'background-color': '#fff',
                    opacity: 0.80
                }).appendTo("body").fadeIn(200);
            }


            var previousPoint = [0, 0, 0];
            $(elem).bind("plothover", function (event, pos, item) {
                if (item) {
                    if (previousPoint[0] != item.datapoint[0]
                        || previousPoint[1] != item.datapoint[1]
                        || previousPoint[2] != item.datapoint[2]
                    ) {
                        previousPoint = item.datapoint;

                        $("#tooltip").remove();

                        var value = item.datapoint[1] - item.datapoint[2];
                        if (item.series.bars.horizontal) {
                            value = item.datapoint[0] - item.datapoint[2];

                        }
                        else {
                            value = item.datapoint[1] - item.datapoint[2];
                        }


                        showTooltip(item.pageX, item.pageY, item.series.label + " " + value.toFixed(0));
                    }
                }
                else {
                    $("#tooltip").remove();
                    previousPoint = [0, 0, 0];
                }
            });

            $scope.$watch("chart", function (newValue, oldValue) {

                if (!$.isEmptyObject($scope.chart)) {
                    if (newValue !== undefined) {
                        if ($scope.chart.options !== undefined)
                            $.plot(elem, $scope.chart.data, $scope.chart.options);
                        else
                            if ($scope.chart.data !== undefined)
                                $.plot(elem, $scope.chart.data);
                    }
                }
            });
            //$scope.$watch("chart.show", function (newValue, oldValue) {

            //    if (newValue != undefined)
            //        $.plot(elem, $scope.chart.data, $scope.chart.options);
            //});

        }
    };
});




