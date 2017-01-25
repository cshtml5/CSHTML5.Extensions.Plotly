using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CSHTML5.Extensions.Plotly;

namespace CSHTML5.Extensions.Plotly.Examples
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            //------------
            // BARS (GROUPED)
            //------------
            ChartControl1.Layout = new Layout()
            {
                Title = "Bar Chart (Grouped)",
                Xaxis = new Axis()
                {
                    Title = "Animal"
                },
                Yaxis = new Axis()
                {
                    Title = "Quantity"
                },
                Width = 500,
                Height = 300
            };
            ChartControl1.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        Name = "Test",
                        X = new List<object>() { "giraffes", "orangutans", "monkeys" },
                        Y = new List<object>() { 20, 14, 23 },
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        Name = "Test2",
                        X = new List<object>() { "giraffes", "orangutans", "monkeys" },
                        Y = new List<object>() { 12, 16, 23 },
                        Type = TraceType.Bar
                    }
                }
            };

            //------------
            // BARS (STACKED)
            //------------
            ChartControl2.Layout = new Layout()
            {
                Title = "Bar Chart (Stacked)",
                BarMode = BarMode.Stack,
                Width = 300,
                Height = 300
            };
            ChartControl2.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        Name = "Test",
                        X = new List<object>() { "giraffes", "orangutans", "monkeys" },
                        Y = new List<object>() { 20, 14, 23 },
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        Name = "Test2",
                        X = new List<object>() { "giraffes", "orangutans", "monkeys" },
                        Y = new List<object>() { 12, 16, 23 },
                        Type = TraceType.Bar
                    }
                }
            };

            //------------
            // SCATTER
            //------------
            ChartControl3.Layout = new Layout()
            {
                Title = "Scatter Chart",
                Width = 400,
                Height = 400
            };
            ChartControl3.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { 10, 15, 13, 17 },
                        Type = TraceType.Scatter,
                    },
                    new Trace()
                    {
                        X = new List<object>() { 2, 3, 4, 5 },
                        Y = new List<object>() { 16, 5, 11, 9 },
                        Type = TraceType.Scatter,
                        Mode = TraceMode.Markers | TraceMode.Text,
                        Text = new List<string>() { "B-a", "B-b", "B-c", "B-d", "B-e" },
                        Marker = new Marker()
                        {
                            Size = 14
                        }
                    },
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { 12, 9, 15, 12 },
                        Type = TraceType.Scatter,
                        Mode = TraceMode.Lines | TraceMode.Markers
                    },
                }
            };

            //------------
            // BAR WITH HOVER TEXT
            //------------
            ChartControl4.Layout = new Layout()
            {
                Title = "Bar with hover text",
                Width = 300,
                Height = 300
            };
            ChartControl4.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { "Product A", "Product B", "Product C" },
                        Y = new List<object>() { 20, 14, 23 },
                        Type = TraceType.Bar,
                        Text = new List<string>() { "27% market share", "24% market share", "19% market share" },
                        Marker = new Marker()
                        {
                            Color = "rgb(158,202,0)",
                            Opacity = 0.6,
                            Line = new Line()
                            {
                                Color = "rgb(255,48,107)",
                                Width = 1.5
                            }
                        }
                    }
                }
            };

            //------------
            // BAR WITH DIRECT LABEL
            //------------
            var AnnotationContent = new List<Annotation>();
            var Xvalues = new List<object>() { "Product A", "Product B", "Product C" };
            var Yvalues = new List<object>() { 20, 14, 23 };
            ChartControl5.Layout = new Layout()
            {
                Title = "Bar Chart with Direct Labels",
                Annotations = AnnotationContent,
                Width = 300,
                Height = 300
            };
            ChartControl5.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = Xvalues,
                        Y = Yvalues,
                        Type = TraceType.Bar,
                        Text = new List<string>() { "27% market share", "24% market share", "19% market share" },
                        Marker = new Marker()
                        {
                            Color = "rgb(158, 202, 225)",
                            Opacity = 0.6,
                            Line = new Line()
                            {
                                Color = "rgb(8, 48, 107)",
                                Width = 1.5
                            }
                        }
                    }
                }
            };

            for (int i = 0; i < Xvalues.Count; i++)
            {
                var result = new Annotation()
                {
                    X = Xvalues[i],
                    Y = Yvalues[i],
                    Text = Yvalues[i].ToString(),
                    Xanchor = "center",
                    Yanchor = "bottom",
                    ShowArrow = false
                };
                AnnotationContent.Add(result);
            }

            //------------
            // BAR WITH DIRECT LABEL
            //------------
            ChartControl6.Layout = new Layout()
            {
                Title = "Bar chart with direct label",
                Xaxis = new Axis()
                {
                    Tickangle = -45
                },
                BarMode = BarMode.Group,
                Width = 500,
                Height = 500
            };
            ChartControl6.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                        Y = new List<object> { 20, 14, 25, 16, 18, 22, 19, 15, 12, 16, 14, 17 },
                        Type = TraceType.Bar,
                        Name = "Primary product",
                        Marker = new Marker()
                        {
                            Color = "rgb(49, 130, 189)",
                            Opacity = 0.7
                        }
                    },
                    new Trace()
                    {
                        X = new List<object> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                        Y = new List<object> { 19, 14, 22, 14, 16, 19, 15, 14, 10, 12, 12, 16 },
                        Type = TraceType.Bar,
                        Name = "Secondary product",
                        Marker = new Marker()
                        {
                            Color = "rgb(204, 204, 204)",
                            Opacity = 0.5
                        }
                    }
                }
            };

            //------------
            // "In'myDiv'ual" BAR COLOR 
            //------------
            ChartControl7.Layout = new Layout()
            {
                Title = "Individual Bar Colors",
                Width = 300,
                Height = 300
            };
            ChartControl7.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { "Feature A", "Feature B", "Feature C", "Feature D", "Feature E" },
                        Y = new List<object>() { 20, 14, 23, 25, 22 },
                        Marker = new Marker()
                        {
                            Color = new List<string>() { "rgba(204,204,204,1)", "rgba(222,45,38,0.8)", "rgba(204,204,204,1)", "rgba(204,204,204,1)", "rgba(204,204,204,1)" }
                        },
                        Type = TraceType.Bar
                    }
                }
            };

            //------------
            // BAR WITH HOVER TEXT 
            //------------
            ChartControl8.Layout = new Layout()
            {
                Title = "Bar With Hover Text",
                Font = new Font()
                {
                    Family = "Raleway, snas-serif"
                },
                ShowLegend = false,
                Xaxis = new Axis()
                {
                    Tickangle = -45
                },
                Yaxis = new Axis()
                {
                    ZeroLine = false,
                    GrigWidth = 2
                },
                BarGap = 0.05,
                Width = 300,
                Height = 300
            };
            ChartControl8.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { "Liam", "Sophie", "Jacob", "Mia", "William", "Olivia" },
                        Y = new List<object>() { 8.0, 8.0, 12.0, 12.0, 13.0, 20.0 },
                        Type = TraceType.Bar,
                        Text = new List<string>() { "4.17 below the mean", "4.17 below the mean", "0.17 below the mean", "0.17 below the mean", "0.83 above the mean", "7.83 above the mean" },
                        Marker = new Marker()
                        {
                            Color = "rgb(142, 124, 195)"
                        }
                    }
                }
            };

            //------------
            // BAR WITH HOVER TEXT 
            //------------
            ChartControl9.Layout = new Layout()
            {
                Title = "US Export of Plastic Scrap",
                Xaxis = new Axis()
                {
                    TickFont = new Font()
                    {
                        Size = 14,
                        Color = "rgb(107, 107, 107)"
                    }
                },
                Yaxis = new Axis()
                {
                    Title = "USD (millions)",
                    TitleFont = new Font()
                    {
                        Size = 16,
                        Color = "rgb(107, 107, 107)"
                    },
                    TickFont = new Font()
                    {
                        Size = 14,
                        Color = "rgb(107, 107, 107)"
                    }
                },
                Legend = new Legend()
                {
                    X = 0,
                    Y = 1.0,
                    BgColor = "rgba(255, 255, 255, 0)",
                    BorderColor = "rgba(255, 255, 255, 0)"
                },
                BarMode = BarMode.Group,
                BarGap = 0.15,
                BarGroupGap = 0.1,
                Width = 600,
                Height = 600
            };
            ChartControl9.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012 },
                        Y = new List<object>() { 219, 146, 112, 127, 124, 180, 236, 207, 236, 263, 350, 430, 474, 526, 488, 537, 500, 439 },
                        Name = "Rest of world",
                        Marker = new Marker()
                        {
                            Color = "rgb(55, 83, 109)"
                        },
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        X = new List<object>() { 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012 },
                        Y = new List<object>() { 16, 13, 10, 11, 28, 37, 43, 55, 56, 88, 105, 156, 270, 299, 340, 403, 549, 499 },
                        Name = "China",
                        Marker = new Marker()
                        {
                            Color = "rgb(26, 118, 255)"
                        },
                        Type = TraceType.Bar
                    }
                }
            };

            //------------
            // WATERFALL BAR
            //------------
            ChartControl10.Layout = new Layout()
            {
                Title = "Annual Profit 2015",
                BarMode = BarMode.Stack,
                PaperBgColor = "rgba(245, 246, 249, 1)",
                PlotBgColor = "rgba(245, 246, 249, 1)",
                ShowLegend = false,
                Annotations = new List<Annotation>(),
                Width = 600,
                Height = 600
            };

            var XData = new List<object>() { "Product\nRevenue", "Services\nRevenue", "Total\nrevenue", "Fixed\ncosts", "Variable\ncosts", "Total costs", "Total" };
            var YData = new List<object>() { 400, 550, 500, 590, 400, 400, 340 };
            var TextList = new List<string>() { "$430K", "$260K", "$690K", "$-120K", "$-200K", "$-320K", "$370K" };

            ChartControl10.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = XData,
                        Y = new List<object> { 0, 430, 0, 570, 370, 370, 0 },
                        Marker = new Marker()
                        {
                            Color = "rgba(1, 1, 1, 0.0)"
                        },
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        X = XData,
                        Y = new List<object>() { 430, 260, 690, 0, 0, 0, 0 },
                        Type = TraceType.Bar,
                        Marker = new Marker()
                        {
                            Color = "rgba(55, 128, 191, 0.7)",
                            Line = new Line()
                            {
                                Color = "rgba(55, 128, 191, 1.0)",
                                Width = 2
                            }
                        }
                    },
                    new Trace()
                    {
                        X = XData,
                        Y = new List<object>() { 0, 0, 0, 120, 200, 320, 0 },
                        Type = TraceType.Bar,
                        Marker = new Marker()
                        {
                            Color = "rgba(219, 64, 82, 0.7)",
                            Line = new Line()
                            {
                                Color = "rgba(219, 64, 82, 1.0)",
                                Width = 2
                            }
                        }
                    },
                    new Trace()
                    {
                        X = XData,
                        Y = new List<object>() { 0, 0, 0, 0, 0, 0, 370 },
                        Type = TraceType.Bar,
                        Marker = new Marker()
                        {
                            Color = "rgba(50, 171, 96, 0.7)",
                            Line = new Line()
                            {
                                Color = "rgba(50, 171, 96, 1.0)",
                                Width = 2
                            }
                        }
                    }
                }
            };
            for (int i = 0; i < 7; i++)
            {
                var result = new Annotation()
                {
                    X = XData[i],
                    Y = YData[i],
                    Text = TextList[i],
                    Font = new Font()
                    {
                        Family = "Arial",
                        Size = 14,
                        Color = "rgba(245, 246, 249, 1)"
                    },
                    ShowArrow = false
                };
                ChartControl10.Layout.Annotations.Add(result);
            }

            //------------
            // BAR WITH RELATIVE BARMODE
            //------------
            ChartControl11.Layout = new Layout()
            {
                BarMode = BarMode.Relative,
                Xaxis = new Axis() { Title = "X axis" },
                Yaxis = new Axis() { Title = "Y axis" },
                Title = "Relative Barmode",
                Width = 300,
                Height = 300
            };
            ChartControl11.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { 1, 4, 9, 16 },
                        Name = "Trace1",
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { 6, -8, -4.5, 8 },
                        Name = "Trace2",
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { -15, -3, 4.5, -8 },
                        Name = "Trace3",
                        Type = TraceType.Bar
                    },
                    new Trace()
                    {
                        X = new List<object>() { 1, 2, 3, 4 },
                        Y = new List<object>() { -1, 3, -3, -4 },
                        Name = "Trace4",
                        Type = TraceType.Bar
                    }
                }
            };

            //------------
            // BASIC PIE CHART
            //------------
            ChartControl12.Layout = new Layout()
            {
                Width = 400,
                Height = 300
            };
            ChartControl12.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        Values = new List<object>() { 19, 26, 55 },
                        Labels = new List<string>() { "Residential", "Non-Residential", "Utility" },
                        Type = TraceType.Pie
                    }
                }
            };

            //------------
            // PIE CHART SUBPLOT
            //------------
            ChartControl13.Layout = new Layout()
            {
                Width = 400,
                Height = 300
            };
            var AllLabels = new List<string>() { "1st", "2nd", "3rd", "4th", "5th" };
            var AllValues = new List<List<object>>()
            {
                new List<object>() { 38, 27, 18, 10, 7 },
                new List<object>() { 28, 26, 21, 15, 10 },
                new List<object>() { 38, 19, 16, 14, 13 },
                new List<object>() { 31, 24, 19, 18, 8 }
            };
            var UltimateColors = new List<List<string>>()
            {
                new List<string>() { "rgb(56, 75, 126)", "rgb(18, 36, 37)", "rgb(34, 53, 101)", "rgb(36, 55, 57)", "rgb(6, 4, 4)" },
                new List<string>() { "rgb(177, 127, 38)", "rgb(205, 152, 36)", "rgb(99, 79, 37)", "rgb(129, 180, 179)", "rgb(124, 103, 37)" },
                new List<string>() { "rgb(33, 75, 99)", "rgb(79, 129, 102)", "rgb(151, 179, 100)", "rgb(175, 49, 35)", "rgb(36, 73, 147)" },
                new List<string>() { "rgb(146, 123, 21)", "rgb(177, 180, 34)", "rgb(206, 206, 40)", "rgb(175, 51, 21)", "rgb(35, 36, 21)" }
            };
            ChartControl13.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        Values = AllValues[0],
                        Labels = AllLabels,
                        Type = TraceType.Pie,
                        Name = "Starry Night",
                        Marker = new Marker() { Colors = UltimateColors[0] },
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0, 0.48 },
                            Y = new List<double>() { 0, 0.49 }
                        },
                        HoverInfo = "label+percent+name",
                        TextInfo = "none"
                    },
                    new Trace()
                    {
                        Values = AllValues[1],
                        Labels = AllLabels,
                        Type = TraceType.Pie,
                        Name = "Sunflowers",
                        Marker = new Marker() { Colors = UltimateColors[1] },
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0.52, 1 },
                            Y = new List<double>() { 0, 0.49 }
                        },
                        HoverInfo = "label+percent+name",
                        TextInfo = "none"
                    },
                    new Trace()
                    {
                        Values = AllValues[2],
                        Labels = AllLabels,
                        Type = TraceType.Pie,
                        Name = "Irises",
                        Marker = new Marker() { Colors = UltimateColors[2] },
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0, 0.48 },
                            Y = new List<double>() { 0.51, 1 }
                        },
                        HoverInfo = "label+percent+name",
                        TextInfo = "none"
                    },
                    new Trace()
                    {
                        Values = AllValues[3],
                        Labels = AllLabels,
                        Type = TraceType.Pie,
                        Name = "The Night Cafe",
                        Marker = new Marker() { Colors = UltimateColors[3] },
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0.52, 1 },
                            Y = new List<double>() { 0.52, 1 }
                        },
                        HoverInfo = "label+percent+name",
                        TextInfo = "none"
                    }
                }
            };

            //------------
            // DONUT CHART
            //------------
            ChartControl14.Layout = new Layout()
            {
                Title = "Global Emissions 1990-2011",
                Annotations = new List<Annotation>()
                {
                    new Annotation()
                    {
                        Font = new Font() { Size = 20 },
                        ShowArrow = false,
                        Text = "GHG",
                        X = 0.17,
                        Y = 0.5
                    },
                    new Annotation()
                    {
                        Font = new Font() { Size = 20 },
                        ShowArrow = false,
                        Text = "CO2",
                        X = 0.82,
                        Y = 0.5
                    }
                },
                Width = 600,
                Height = 400
            };
            ChartControl14.Data = new Data()
            {
                Traces = new List<Trace>()
                {
                    new Trace()
                    {
                        Values = new List<object>() { 16, 15, 12, 6, 5, 4, 42 },
                        Labels = new List<string>() { "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0, 0.48 }
                        },
                        Name = "GHG Emissions",
                        HoverInfo = "label+percent+name",
                        Hole = 0.4,
                        Type = TraceType.Pie
                    },
                    new Trace()
                    {
                        Values = new List<object>() { 27, 11, 25, 8, 1, 3, 25 },
                        Labels = new List<string>() { "US", "China", "European Union", "Russian Federation", "Brazil", "India", "Rest of World" },
                        Text = "CO2",
                        TextPosition = "inside",
                        Domain = new Domain()
                        {
                            X = new List<double>() { 0.52, 1 }
                        },
                        Name = "CO2 Emissions",
                        HoverInfo = "label+percent+name",
                        Hole = 0.4,
                        Type = TraceType.Pie
                    }
                }
            };
        }
    }
}
