using EM.FlotCharts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ChartController : ApiController
    {
        // GET api/<controller>
        public Chart Get()
        {
            var chart = new Chart();

            chart.Options.XAxis.AutoscaleMargin = 0.02;
            chart.Options.XAxis.ExtensionOptions.Add("axisLabel", "");
            chart.Options.XAxis.ExtensionOptions.Add("axisLabelFontFamily", "Verdana, Arial, Helvetica, Tahoma, sans-serif");
            chart.Options.XAxis.ExtensionOptions.Add("axisLabelFontSizePixels", 12);
            chart.Options.XAxis.ExtensionOptions.Add("axisLabelPadding", 5);
            chart.Options.XAxis.ExtensionOptions.Add("axisLabelUseCanvas", true);
            chart.Options.XAxis.Min = -0.1;
            chart.Options.XAxis.Show = true;

            return chart;
        }

        // GET api/<controller>/5
        public Chart Get(int id)
        {
            switch (id)
            {
                default:
                case 0: //Basic Example
                    return CreateBasicChart();
                case 1:
                    return CreateSeriesTypesChart();
                case 2:
                    return CreateCategoriesChart();
                case 3:
                    return CreateBasicOptionsChart();
                case 4:
                    return CreateAnnotationssChart();
                case 5:
                    return CreateSelectionChart();
                case 6:
                    return CreateSelectionAndZoomingChart();
                case 7:
                    return CreateInteractivityChart();
                case 8:
                    return CreateNavigationChart();
                case 9:
                    return CreateSymbolsChart();
                case 10:
                    return CreateTimeAxesChart();
                case 11:
                    return CreateVisitorsChart();
            }
        }
                
        private Chart CreateVisitorsChart()
        {
            var chart = new Chart();
            var data = new List<List<object>> { new List<object> { 1196463600000, 0 }, new List<object> { 1196550000000, 0 }, new List<object> { 1196636400000, 0 }, new List<object> { 1196722800000, 77 }, new List<object> { 1196809200000, 3636 }, new List<object> { 1196895600000, 3575 }, new List<object> { 1196982000000, 2736 }, new List<object> { 1197068400000, 1086 }, new List<object> { 1197154800000, 676 }, new List<object> { 1197241200000, 1205 }, new List<object> { 1197327600000, 906 }, new List<object> { 1197414000000, 710 }, new List<object> { 1197500400000, 639 }, new List<object> { 1197586800000, 540 }, new List<object> { 1197673200000, 435 }, new List<object> { 1197759600000, 301 }, new List<object> { 1197846000000, 575 }, new List<object> { 1197932400000, 481 }, new List<object> { 1198018800000, 591 }, new List<object> { 1198105200000, 608 }, new List<object> { 1198191600000, 459 }, new List<object> { 1198278000000, 234 }, new List<object> { 1198364400000, 1352 }, new List<object> { 1198450800000, 686 }, new List<object> { 1198537200000, 279 }, new List<object> { 1198623600000, 449 }, new List<object> { 1198710000000, 468 }, new List<object> { 1198796400000, 392 }, new List<object> { 1198882800000, 282 }, new List<object> { 1198969200000, 208 }, new List<object> { 1199055600000, 229 }, new List<object> { 1199142000000, 177 }, new List<object> { 1199228400000, 374 }, new List<object> { 1199314800000, 436 }, new List<object> { 1199401200000, 404 }, new List<object> { 1199487600000, 253 }, new List<object> { 1199574000000, 218 }, new List<object> { 1199660400000, 476 }, new List<object> { 1199746800000, 462 }, new List<object> { 1199833200000, 448 }, new List<object> { 1199919600000, 442 }, new List<object> { 1200006000000, 403 }, new List<object> { 1200092400000, 204 }, new List<object> { 1200178800000, 194 }, new List<object> { 1200265200000, 327 }, new List<object> { 1200351600000, 374 }, new List<object> { 1200438000000, 507 }, new List<object> { 1200524400000, 546 }, new List<object> { 1200610800000, 482 }, new List<object> { 1200697200000, 283 }, new List<object> { 1200783600000, 221 }, new List<object> { 1200870000000, 483 }, new List<object> { 1200956400000, 523 }, new List<object> { 1201042800000, 528 }, new List<object> { 1201129200000, 483 }, new List<object> { 1201215600000, 452 }, new List<object> { 1201302000000, 270 }, new List<object> { 1201388400000, 222 }, new List<object> { 1201474800000, 439 }, new List<object> { 1201561200000, 559 }, new List<object> { 1201647600000, 521 }, new List<object> { 1201734000000, 477 }, new List<object> { 1201820400000, 442 }, new List<object> { 1201906800000, 252 }, new List<object> { 1201993200000, 236 }, new List<object> { 1202079600000, 525 }, new List<object> { 1202166000000, 477 }, new List<object> { 1202252400000, 386 }, new List<object> { 1202338800000, 409 }, new List<object> { 1202425200000, 408 }, new List<object> { 1202511600000, 237 }, new List<object> { 1202598000000, 193 }, new List<object> { 1202684400000, 357 }, new List<object> { 1202770800000, 414 }, new List<object> { 1202857200000, 393 }, new List<object> { 1202943600000, 353 }, new List<object> { 1203030000000, 364 }, new List<object> { 1203116400000, 215 }, new List<object> { 1203202800000, 214 }, new List<object> { 1203289200000, 356 }, new List<object> { 1203375600000, 399 }, new List<object> { 1203462000000, 334 }, new List<object> { 1203548400000, 348 }, new List<object> { 1203634800000, 243 }, new List<object> { 1203721200000, 126 }, new List<object> { 1203807600000, 157 }, new List<object> { 1203894000000, 288 } };

            for (var i = 0; i < data.Count; ++i)
            {
                data[i][0] = (60 * 60 * 1000) + (long)data[i][0];
            }
            var series = chart.AddDataSeries(data);
                        
            chart.Options.XAxis.Mode = "time";
            chart.Options.XAxis.TickLength = 5;
            
            chart.Options.ExtensionOptions.Add("selection", new { mode = "x" });

            //TODO try get it to work with functions chart.Options.Grid.Markings;

            return chart;
        }

        private Chart CreateTimeAxesChart()
        {
            var chart = new Chart();
            var data = new List<List<object>> { new List<object> { -373597200000, 315.71 }, new List<object> { -370918800000, 317.45 }, new List<object> { -368326800000, 317.50 }, new List<object> { -363056400000, 315.86 }, new List<object> { -360378000000, 314.93 }, new List<object> { -357699600000, 313.19 }, new List<object> { -352429200000, 313.34 }, new List<object> { -349837200000, 314.67 }, new List<object> { -347158800000, 315.58 }, new List<object> { -344480400000, 316.47 }, new List<object> { -342061200000, 316.65 }, new List<object> { -339382800000, 317.71 }, new List<object> { -336790800000, 318.29 }, new List<object> { -334112400000, 318.16 }, new List<object> { -331520400000, 316.55 }, new List<object> { -328842000000, 314.80 }, new List<object> { -326163600000, 313.84 }, new List<object> { -323571600000, 313.34 }, new List<object> { -320893200000, 314.81 }, new List<object> { -318301200000, 315.59 }, new List<object> { -315622800000, 316.43 }, new List<object> { -312944400000, 316.97 }, new List<object> { -310438800000, 317.58 }, new List<object> { -307760400000, 319.03 }, new List<object> { -305168400000, 320.03 }, new List<object> { -302490000000, 319.59 }, new List<object> { -299898000000, 318.18 }, new List<object> { -297219600000, 315.91 }, new List<object> { -294541200000, 314.16 }, new List<object> { -291949200000, 313.83 }, new List<object> { -289270800000, 315.00 }, new List<object> { -286678800000, 316.19 }, new List<object> { -284000400000, 316.89 }, new List<object> { -281322000000, 317.70 }, new List<object> { -278902800000, 318.54 }, new List<object> { -276224400000, 319.48 }, new List<object> { -273632400000, 320.58 }, new List<object> { -270954000000, 319.78 }, new List<object> { -268362000000, 318.58 }, new List<object> { -265683600000, 316.79 }, new List<object> { -263005200000, 314.99 }, new List<object> { -260413200000, 315.31 }, new List<object> { -257734800000, 316.10 }, new List<object> { -255142800000, 317.01 }, new List<object> { -252464400000, 317.94 }, new List<object> { -249786000000, 318.56 }, new List<object> { -247366800000, 319.69 }, new List<object> { -244688400000, 320.58 }, new List<object> { -242096400000, 321.01 }, new List<object> { -239418000000, 320.61 }, new List<object> { -236826000000, 319.61 }, new List<object> { -234147600000, 317.40 }, new List<object> { -231469200000, 316.26 }, new List<object> { -228877200000, 315.42 }, new List<object> { -226198800000, 316.69 }, new List<object> { -223606800000, 317.69 }, new List<object> { -220928400000, 318.74 }, new List<object> { -218250000000, 319.08 }, new List<object> { -215830800000, 319.86 }, new List<object> { -213152400000, 321.39 }, new List<object> { -210560400000, 322.24 }, new List<object> { -207882000000, 321.47 }, new List<object> { -205290000000, 319.74 }, new List<object> { -202611600000, 317.77 }, new List<object> { -199933200000, 316.21 }, new List<object> { -197341200000, 315.99 }, new List<object> { -194662800000, 317.07 }, new List<object> { -192070800000, 318.36 }, new List<object> { -189392400000, 319.57 }, new List<object> { -178938000000, 322.23 }, new List<object> { -176259600000, 321.89 }, new List<object> { -173667600000, 320.44 }, new List<object> { -170989200000, 318.70 }, new List<object> { -168310800000, 316.70 }, new List<object> { -165718800000, 316.87 }, new List<object> { -163040400000, 317.68 }, new List<object> { -160448400000, 318.71 }, new List<object> { -157770000000, 319.44 }, new List<object> { -155091600000, 320.44 }, new List<object> { -152672400000, 320.89 }, new List<object> { -149994000000, 322.13 }, new List<object> { -147402000000, 322.16 }, new List<object> { -144723600000, 321.87 }, new List<object> { -142131600000, 321.21 }, new List<object> { -139453200000, 318.87 }, new List<object> { -136774800000, 317.81 }, new List<object> { -134182800000, 317.30 }, new List<object> { -131504400000, 318.87 }, new List<object> { -128912400000, 319.42 }, new List<object> { -126234000000, 320.62 }, new List<object> { -123555600000, 321.59 }, new List<object> { -121136400000, 322.39 }, new List<object> { -118458000000, 323.70 }, new List<object> { -115866000000, 324.07 }, new List<object> { -113187600000, 323.75 }, new List<object> { -110595600000, 322.40 }, new List<object> { -107917200000, 320.37 }, new List<object> { -105238800000, 318.64 }, new List<object> { -102646800000, 318.10 }, new List<object> { -99968400000, 319.79 }, new List<object> { -97376400000, 321.03 }, new List<object> { -94698000000, 322.33 }, new List<object> { -92019600000, 322.50 }, new List<object> { -89600400000, 323.04 }, new List<object> { -86922000000, 324.42 }, new List<object> { -84330000000, 325.00 }, new List<object> { -81651600000, 324.09 }, new List<object> { -79059600000, 322.55 }, new List<object> { -76381200000, 320.92 }, new List<object> { -73702800000, 319.26 }, new List<object> { -71110800000, 319.39 }, new List<object> { -68432400000, 320.72 }, new List<object> { -65840400000, 321.96 }, new List<object> { -63162000000, 322.57 }, new List<object> { -60483600000, 323.15 }, new List<object> { -57978000000, 323.89 }, new List<object> { -55299600000, 325.02 }, new List<object> { -52707600000, 325.57 }, new List<object> { -50029200000, 325.36 }, new List<object> { -47437200000, 324.14 }, new List<object> { -44758800000, 322.11 }, new List<object> { -42080400000, 320.33 }, new List<object> { -39488400000, 320.25 }, new List<object> { -36810000000, 321.32 }, new List<object> { -34218000000, 322.90 }, new List<object> { -31539600000, 324.00 }, new List<object> { -28861200000, 324.42 }, new List<object> { -26442000000, 325.64 }, new List<object> { -23763600000, 326.66 }, new List<object> { -21171600000, 327.38 }, new List<object> { -18493200000, 326.70 }, new List<object> { -15901200000, 325.89 }, new List<object> { -13222800000, 323.67 }, new List<object> { -10544400000, 322.38 }, new List<object> { -7952400000, 321.78 }, new List<object> { -5274000000, 322.85 }, new List<object> { -2682000000, 324.12 }, new List<object> { -3600000, 325.06 }, new List<object> { 2674800000, 325.98 }, new List<object> { 5094000000, 326.93 }, new List<object> { 7772400000, 328.13 }, new List<object> { 10364400000, 328.07 }, new List<object> { 13042800000, 327.66 }, new List<object> { 15634800000, 326.35 }, new List<object> { 18313200000, 324.69 }, new List<object> { 20991600000, 323.10 }, new List<object> { 23583600000, 323.07 }, new List<object> { 26262000000, 324.01 }, new List<object> { 28854000000, 325.13 }, new List<object> { 31532400000, 326.17 }, new List<object> { 34210800000, 326.68 }, new List<object> { 36630000000, 327.18 }, new List<object> { 39308400000, 327.78 }, new List<object> { 41900400000, 328.92 }, new List<object> { 44578800000, 328.57 }, new List<object> { 47170800000, 327.37 }, new List<object> { 49849200000, 325.43 }, new List<object> { 52527600000, 323.36 }, new List<object> { 55119600000, 323.56 }, new List<object> { 57798000000, 324.80 }, new List<object> { 60390000000, 326.01 }, new List<object> { 63068400000, 326.77 }, new List<object> { 65746800000, 327.63 }, new List<object> { 68252400000, 327.75 }, new List<object> { 70930800000, 329.72 }, new List<object> { 73522800000, 330.07 }, new List<object> { 76201200000, 329.09 }, new List<object> { 78793200000, 328.05 }, new List<object> { 81471600000, 326.32 }, new List<object> { 84150000000, 324.84 }, new List<object> { 86742000000, 325.20 }, new List<object> { 89420400000, 326.50 }, new List<object> { 92012400000, 327.55 }, new List<object> { 94690800000, 328.54 }, new List<object> { 97369200000, 329.56 }, new List<object> { 99788400000, 330.30 }, new List<object> { 102466800000, 331.50 }, new List<object> { 105058800000, 332.48 }, new List<object> { 107737200000, 332.07 }, new List<object> { 110329200000, 330.87 }, new List<object> { 113007600000, 329.31 }, new List<object> { 115686000000, 327.51 }, new List<object> { 118278000000, 327.18 }, new List<object> { 120956400000, 328.16 }, new List<object> { 123548400000, 328.64 }, new List<object> { 126226800000, 329.35 }, new List<object> { 128905200000, 330.71 }, new List<object> { 131324400000, 331.48 }, new List<object> { 134002800000, 332.65 }, new List<object> { 136594800000, 333.16 }, new List<object> { 139273200000, 332.06 }, new List<object> { 141865200000, 330.99 }, new List<object> { 144543600000, 329.17 }, new List<object> { 147222000000, 327.41 }, new List<object> { 149814000000, 327.20 }, new List<object> { 152492400000, 328.33 }, new List<object> { 155084400000, 329.50 }, new List<object> { 157762800000, 330.68 }, new List<object> { 160441200000, 331.41 }, new List<object> { 162860400000, 331.85 }, new List<object> { 165538800000, 333.29 }, new List<object> { 168130800000, 333.91 }, new List<object> { 170809200000, 333.40 }, new List<object> { 173401200000, 331.78 }, new List<object> { 176079600000, 329.88 }, new List<object> { 178758000000, 328.57 }, new List<object> { 181350000000, 328.46 }, new List<object> { 184028400000, 329.26 }, new List<object> { 189298800000, 331.71 }, new List<object> { 191977200000, 332.76 }, new List<object> { 194482800000, 333.48 }, new List<object> { 197161200000, 334.78 }, new List<object> { 199753200000, 334.78 }, new List<object> { 202431600000, 334.17 }, new List<object> { 205023600000, 332.78 }, new List<object> { 207702000000, 330.64 }, new List<object> { 210380400000, 328.95 }, new List<object> { 212972400000, 328.77 }, new List<object> { 215650800000, 330.23 }, new List<object> { 218242800000, 331.69 }, new List<object> { 220921200000, 332.70 }, new List<object> { 223599600000, 333.24 }, new List<object> { 226018800000, 334.96 }, new List<object> { 228697200000, 336.04 }, new List<object> { 231289200000, 336.82 }, new List<object> { 233967600000, 336.13 }, new List<object> { 236559600000, 334.73 }, new List<object> { 239238000000, 332.52 }, new List<object> { 241916400000, 331.19 }, new List<object> { 244508400000, 331.19 }, new List<object> { 247186800000, 332.35 }, new List<object> { 249778800000, 333.47 }, new List<object> { 252457200000, 335.11 }, new List<object> { 255135600000, 335.26 }, new List<object> { 257554800000, 336.60 }, new List<object> { 260233200000, 337.77 }, new List<object> { 262825200000, 338.00 }, new List<object> { 265503600000, 337.99 }, new List<object> { 268095600000, 336.48 }, new List<object> { 270774000000, 334.37 }, new List<object> { 273452400000, 332.27 }, new List<object> { 276044400000, 332.41 }, new List<object> { 278722800000, 333.76 }, new List<object> { 281314800000, 334.83 }, new List<object> { 283993200000, 336.21 }, new List<object> { 286671600000, 336.64 }, new List<object> { 289090800000, 338.12 }, new List<object> { 291769200000, 339.02 }, new List<object> { 294361200000, 339.02 }, new List<object> { 297039600000, 339.20 }, new List<object> { 299631600000, 337.58 }, new List<object> { 302310000000, 335.55 }, new List<object> { 304988400000, 333.89 }, new List<object> { 307580400000, 334.14 }, new List<object> { 310258800000, 335.26 }, new List<object> { 312850800000, 336.71 }, new List<object> { 315529200000, 337.81 }, new List<object> { 318207600000, 338.29 }, new List<object> { 320713200000, 340.04 }, new List<object> { 323391600000, 340.86 }, new List<object> { 325980000000, 341.47 }, new List<object> { 328658400000, 341.26 }, new List<object> { 331250400000, 339.29 }, new List<object> { 333928800000, 337.60 }, new List<object> { 336607200000, 336.12 }, new List<object> { 339202800000, 336.08 }, new List<object> { 341881200000, 337.22 }, new List<object> { 344473200000, 338.34 }, new List<object> { 347151600000, 339.36 }, new List<object> { 349830000000, 340.51 }, new List<object> { 352249200000, 341.57 }, new List<object> { 354924000000, 342.56 }, new List<object> { 357516000000, 343.01 }, new List<object> { 360194400000, 342.47 }, new List<object> { 362786400000, 340.71 }, new List<object> { 365464800000, 338.52 }, new List<object> { 368143200000, 336.96 }, new List<object> { 370738800000, 337.13 }, new List<object> { 373417200000, 338.58 }, new List<object> { 376009200000, 339.89 }, new List<object> { 378687600000, 340.93 }, new List<object> { 381366000000, 341.69 }, new List<object> { 383785200000, 342.69 }, new List<object> { 389052000000, 344.30 }, new List<object> { 391730400000, 343.43 }, new List<object> { 394322400000, 341.88 }, new List<object> { 397000800000, 339.89 }, new List<object> { 399679200000, 337.95 }, new List<object> { 402274800000, 338.10 }, new List<object> { 404953200000, 339.27 }, new List<object> { 407545200000, 340.67 }, new List<object> { 410223600000, 341.42 }, new List<object> { 412902000000, 342.68 }, new List<object> { 415321200000, 343.46 }, new List<object> { 417996000000, 345.10 }, new List<object> { 420588000000, 345.76 }, new List<object> { 423266400000, 345.36 }, new List<object> { 425858400000, 343.91 }, new List<object> { 428536800000, 342.05 }, new List<object> { 431215200000, 340.00 }, new List<object> { 433810800000, 340.12 }, new List<object> { 436489200000, 341.33 }, new List<object> { 439081200000, 342.94 }, new List<object> { 441759600000, 343.87 }, new List<object> { 444438000000, 344.60 }, new List<object> { 446943600000, 345.20 }, new List<object> { 452210400000, 347.36 }, new List<object> { 454888800000, 346.74 }, new List<object> { 457480800000, 345.41 }, new List<object> { 460159200000, 343.01 }, new List<object> { 462837600000, 341.23 }, new List<object> { 465433200000, 341.52 }, new List<object> { 468111600000, 342.86 }, new List<object> { 470703600000, 344.41 }, new List<object> { 473382000000, 345.09 }, new List<object> { 476060400000, 345.89 }, new List<object> { 478479600000, 347.49 }, new List<object> { 481154400000, 348.00 }, new List<object> { 483746400000, 348.75 }, new List<object> { 486424800000, 348.19 }, new List<object> { 489016800000, 346.54 }, new List<object> { 491695200000, 344.63 }, new List<object> { 494373600000, 343.03 }, new List<object> { 496969200000, 342.92 }, new List<object> { 499647600000, 344.24 }, new List<object> { 502239600000, 345.62 }, new List<object> { 504918000000, 346.43 }, new List<object> { 507596400000, 346.94 }, new List<object> { 510015600000, 347.88 }, new List<object> { 512690400000, 349.57 }, new List<object> { 515282400000, 350.35 }, new List<object> { 517960800000, 349.72 }, new List<object> { 520552800000, 347.78 }, new List<object> { 523231200000, 345.86 }, new List<object> { 525909600000, 344.84 }, new List<object> { 528505200000, 344.32 }, new List<object> { 531183600000, 345.67 }, new List<object> { 533775600000, 346.88 }, new List<object> { 536454000000, 348.19 }, new List<object> { 539132400000, 348.55 }, new List<object> { 541551600000, 349.52 }, new List<object> { 544226400000, 351.12 }, new List<object> { 546818400000, 351.84 }, new List<object> { 549496800000, 351.49 }, new List<object> { 552088800000, 349.82 }, new List<object> { 554767200000, 347.63 }, new List<object> { 557445600000, 346.38 }, new List<object> { 560041200000, 346.49 }, new List<object> { 562719600000, 347.75 }, new List<object> { 565311600000, 349.03 }, new List<object> { 567990000000, 350.20 }, new List<object> { 570668400000, 351.61 }, new List<object> { 573174000000, 352.22 }, new List<object> { 575848800000, 353.53 }, new List<object> { 578440800000, 354.14 }, new List<object> { 581119200000, 353.62 }, new List<object> { 583711200000, 352.53 }, new List<object> { 586389600000, 350.41 }, new List<object> { 589068000000, 348.84 }, new List<object> { 591663600000, 348.94 }, new List<object> { 594342000000, 350.04 }, new List<object> { 596934000000, 351.29 }, new List<object> { 599612400000, 352.72 }, new List<object> { 602290800000, 353.10 }, new List<object> { 604710000000, 353.65 }, new List<object> { 607384800000, 355.43 }, new List<object> { 609976800000, 355.70 }, new List<object> { 612655200000, 355.11 }, new List<object> { 615247200000, 353.79 }, new List<object> { 617925600000, 351.42 }, new List<object> { 620604000000, 349.81 }, new List<object> { 623199600000, 350.11 }, new List<object> { 625878000000, 351.26 }, new List<object> { 628470000000, 352.63 }, new List<object> { 631148400000, 353.64 }, new List<object> { 633826800000, 354.72 }, new List<object> { 636246000000, 355.49 }, new List<object> { 638920800000, 356.09 }, new List<object> { 641512800000, 357.08 }, new List<object> { 644191200000, 356.11 }, new List<object> { 646783200000, 354.70 }, new List<object> { 649461600000, 352.68 }, new List<object> { 652140000000, 351.05 }, new List<object> { 654735600000, 351.36 }, new List<object> { 657414000000, 352.81 }, new List<object> { 660006000000, 354.22 }, new List<object> { 662684400000, 354.85 }, new List<object> { 665362800000, 355.66 }, new List<object> { 667782000000, 357.04 }, new List<object> { 670456800000, 358.40 }, new List<object> { 673048800000, 359.00 }, new List<object> { 675727200000, 357.99 }, new List<object> { 678319200000, 356.00 }, new List<object> { 680997600000, 353.78 }, new List<object> { 683676000000, 352.20 }, new List<object> { 686271600000, 352.22 }, new List<object> { 688950000000, 353.70 }, new List<object> { 691542000000, 354.98 }, new List<object> { 694220400000, 356.09 }, new List<object> { 696898800000, 356.85 }, new List<object> { 699404400000, 357.73 }, new List<object> { 702079200000, 358.91 }, new List<object> { 704671200000, 359.45 }, new List<object> { 707349600000, 359.19 }, new List<object> { 709941600000, 356.72 }, new List<object> { 712620000000, 354.79 }, new List<object> { 715298400000, 352.79 }, new List<object> { 717894000000, 353.20 }, new List<object> { 720572400000, 354.15 }, new List<object> { 723164400000, 355.39 }, new List<object> { 725842800000, 356.77 }, new List<object> { 728521200000, 357.17 }, new List<object> { 730940400000, 358.26 }, new List<object> { 733615200000, 359.16 }, new List<object> { 736207200000, 360.07 }, new List<object> { 738885600000, 359.41 }, new List<object> { 741477600000, 357.44 }, new List<object> { 744156000000, 355.30 }, new List<object> { 746834400000, 353.87 }, new List<object> { 749430000000, 354.04 }, new List<object> { 752108400000, 355.27 }, new List<object> { 754700400000, 356.70 }, new List<object> { 757378800000, 358.00 }, new List<object> { 760057200000, 358.81 }, new List<object> { 762476400000, 359.68 }, new List<object> { 765151200000, 361.13 }, new List<object> { 767743200000, 361.48 }, new List<object> { 770421600000, 360.60 }, new List<object> { 773013600000, 359.20 }, new List<object> { 775692000000, 357.23 }, new List<object> { 778370400000, 355.42 }, new List<object> { 780966000000, 355.89 }, new List<object> { 783644400000, 357.41 }, new List<object> { 786236400000, 358.74 }, new List<object> { 788914800000, 359.73 }, new List<object> { 791593200000, 360.61 }, new List<object> { 794012400000, 361.58 }, new List<object> { 796687200000, 363.05 }, new List<object> { 799279200000, 363.62 }, new List<object> { 801957600000, 363.03 }, new List<object> { 804549600000, 361.55 }, new List<object> { 807228000000, 358.94 }, new List<object> { 809906400000, 357.93 }, new List<object> { 812502000000, 357.80 }, new List<object> { 815180400000, 359.22 }, new List<object> { 817772400000, 360.44 }, new List<object> { 820450800000, 361.83 }, new List<object> { 823129200000, 362.95 }, new List<object> { 825634800000, 363.91 }, new List<object> { 828309600000, 364.28 }, new List<object> { 830901600000, 364.94 }, new List<object> { 833580000000, 364.70 }, new List<object> { 836172000000, 363.31 }, new List<object> { 838850400000, 361.15 }, new List<object> { 841528800000, 359.40 }, new List<object> { 844120800000, 359.34 }, new List<object> { 846802800000, 360.62 }, new List<object> { 849394800000, 361.96 }, new List<object> { 852073200000, 362.81 }, new List<object> { 854751600000, 363.87 }, new List<object> { 857170800000, 364.25 }, new List<object> { 859845600000, 366.02 }, new List<object> { 862437600000, 366.46 }, new List<object> { 865116000000, 365.32 }, new List<object> { 867708000000, 364.07 }, new List<object> { 870386400000, 361.95 }, new List<object> { 873064800000, 360.06 }, new List<object> { 875656800000, 360.49 }, new List<object> { 878338800000, 362.19 }, new List<object> { 880930800000, 364.12 }, new List<object> { 883609200000, 364.99 }, new List<object> { 886287600000, 365.82 }, new List<object> { 888706800000, 366.95 }, new List<object> { 891381600000, 368.42 }, new List<object> { 893973600000, 369.33 }, new List<object> { 896652000000, 368.78 }, new List<object> { 899244000000, 367.59 }, new List<object> { 901922400000, 365.84 }, new List<object> { 904600800000, 363.83 }, new List<object> { 907192800000, 364.18 }, new List<object> { 909874800000, 365.34 }, new List<object> { 912466800000, 366.93 }, new List<object> { 915145200000, 367.94 }, new List<object> { 917823600000, 368.82 }, new List<object> { 920242800000, 369.46 }, new List<object> { 922917600000, 370.77 }, new List<object> { 925509600000, 370.66 }, new List<object> { 928188000000, 370.10 }, new List<object> { 930780000000, 369.08 }, new List<object> { 933458400000, 366.66 }, new List<object> { 936136800000, 364.60 }, new List<object> { 938728800000, 365.17 }, new List<object> { 941410800000, 366.51 }, new List<object> { 944002800000, 367.89 }, new List<object> { 946681200000, 369.04 }, new List<object> { 949359600000, 369.35 }, new List<object> { 951865200000, 370.38 }, new List<object> { 954540000000, 371.63 }, new List<object> { 957132000000, 371.32 }, new List<object> { 959810400000, 371.53 }, new List<object> { 962402400000, 369.75 }, new List<object> { 965080800000, 368.23 }, new List<object> { 967759200000, 366.87 }, new List<object> { 970351200000, 366.94 }, new List<object> { 973033200000, 368.27 }, new List<object> { 975625200000, 369.64 }, new List<object> { 978303600000, 370.46 }, new List<object> { 980982000000, 371.44 }, new List<object> { 983401200000, 372.37 }, new List<object> { 986076000000, 373.33 }, new List<object> { 988668000000, 373.77 }, new List<object> { 991346400000, 373.09 }, new List<object> { 993938400000, 371.51 }, new List<object> { 996616800000, 369.55 }, new List<object> { 999295200000, 368.12 }, new List<object> { 1001887200000, 368.38 }, new List<object> { 1004569200000, 369.66 }, new List<object> { 1007161200000, 371.11 }, new List<object> { 1009839600000, 372.36 }, new List<object> { 1012518000000, 373.09 }, new List<object> { 1014937200000, 373.81 }, new List<object> { 1017612000000, 374.93 }, new List<object> { 1020204000000, 375.58 }, new List<object> { 1022882400000, 375.44 }, new List<object> { 1025474400000, 373.86 }, new List<object> { 1028152800000, 371.77 }, new List<object> { 1030831200000, 370.73 }, new List<object> { 1033423200000, 370.50 }, new List<object> { 1036105200000, 372.18 }, new List<object> { 1038697200000, 373.70 }, new List<object> { 1041375600000, 374.92 }, new List<object> { 1044054000000, 375.62 }, new List<object> { 1046473200000, 376.51 }, new List<object> { 1049148000000, 377.75 }, new List<object> { 1051740000000, 378.54 }, new List<object> { 1054418400000, 378.20 }, new List<object> { 1057010400000, 376.68 }, new List<object> { 1059688800000, 374.43 }, new List<object> { 1062367200000, 373.11 }, new List<object> { 1064959200000, 373.10 }, new List<object> { 1067641200000, 374.77 }, new List<object> { 1070233200000, 375.97 }, new List<object> { 1072911600000, 377.03 }, new List<object> { 1075590000000, 377.87 }, new List<object> { 1078095600000, 378.88 }, new List<object> { 1080770400000, 380.42 }, new List<object> { 1083362400000, 380.62 }, new List<object> { 1086040800000, 379.70 }, new List<object> { 1088632800000, 377.43 }, new List<object> { 1091311200000, 376.32 }, new List<object> { 1093989600000, 374.19 }, new List<object> { 1096581600000, 374.47 }, new List<object> { 1099263600000, 376.15 }, new List<object> { 1101855600000, 377.51 }, new List<object> { 1104534000000, 378.43 }, new List<object> { 1107212400000, 379.70 }, new List<object> { 1109631600000, 380.92 }, new List<object> { 1112306400000, 382.18 }, new List<object> { 1114898400000, 382.45 }, new List<object> { 1117576800000, 382.14 }, new List<object> { 1120168800000, 380.60 }, new List<object> { 1122847200000, 378.64 }, new List<object> { 1125525600000, 376.73 }, new List<object> { 1128117600000, 376.84 }, new List<object> { 1130799600000, 378.29 }, new List<object> { 1133391600000, 380.06 }, new List<object> { 1136070000000, 381.40 }, new List<object> { 1138748400000, 382.20 }, new List<object> { 1141167600000, 382.66 }, new List<object> { 1143842400000, 384.69 }, new List<object> { 1146434400000, 384.94 }, new List<object> { 1149112800000, 384.01 }, new List<object> { 1151704800000, 382.14 }, new List<object> { 1154383200000, 380.31 }, new List<object> { 1157061600000, 378.81 }, new List<object> { 1159653600000, 379.03 }, new List<object> { 1162335600000, 380.17 }, new List<object> { 1164927600000, 381.85 }, new List<object> { 1167606000000, 382.94 }, new List<object> { 1170284400000, 383.86 }, new List<object> { 1172703600000, 384.49 }, new List<object> { 1175378400000, 386.37 }, new List<object> { 1177970400000, 386.54 }, new List<object> { 1180648800000, 385.98 }, new List<object> { 1183240800000, 384.36 }, new List<object> { 1185919200000, 381.85 }, new List<object> { 1188597600000, 380.74 }, new List<object> { 1191189600000, 381.15 }, new List<object> { 1193871600000, 382.38 }, new List<object> { 1196463600000, 383.94 }, new List<object> { 1199142000000, 385.44 } };

            var series = chart.AddDataSeries(data);

            chart.Options.XAxis.Mode = "time";

            return chart;
        }


        private List<List<object>> generate(double offset, double amplitude)
        {

            var res = new List<List<object>>();
            var start = 0.0;
            var end = 10.0;

            for (var i = 0.0; i <= 50; ++i)
            {
                var x = start + i / 50 * (end - start);
                res.Add(new List<object> { x, amplitude * Math.Sin(x + offset) });
            }

            return res;
        }

        private Chart CreateSymbolsChart()
        {
            var chart = new Chart();

            var series = chart.AddDataSeries(generate(2, 1.8));
            series.ExtensionOptions.Add("symbol", "circle");

            series = chart.AddDataSeries(generate(3, 1.5));
            series.ExtensionOptions.Add("symbol", "square");

            series = chart.AddDataSeries(generate(4, 0.9));
            series.ExtensionOptions.Add("symbol", "diamond");

            series = chart.AddDataSeries(generate(6, 1.4));
            series.ExtensionOptions.Add("symbol", "triangle");

            series = chart.AddDataSeries(generate(7, 1.1));
            series.ExtensionOptions.Add("symbol", "cross");

            chart.Options.Series.Points.Show = true;
            chart.Options.Series.Points.Radius = 3;

            chart.Options.Grid.Hoverable = true;

            return chart;
        }

        // generate data set from a parametric function with a fractal look
        delegate double MathFunc(double d);

        private double sumf(MathFunc f, double t, double m)
        {
            var res = 0.0;
            for (var i = 1.0; i < m; ++i)
            {
                res += (double)f.DynamicInvoke(i * i * t) / (i * i);
            }
            return res;
        }


        private Chart CreateNavigationChart()
        {
            var chart = new Chart();



            var d1 = new List<List<object>>();
            for (var t = 0.0; t <= 2 * Math.PI; t += 0.01)
            {
                d1.Add(new List<object> { sumf(Math.Cos, t, 10.0), sumf(Math.Sin, t, 10.0) });
            }

            chart.AddDataSeries(d1);
            chart.Options.Series.Lines.Show = true;
            chart.Options.Series.ShadowSize = 0;

            chart.Options.XAxis.ExtensionOptions.Add("zoomRange", new List<double> { 0.1, 10 });
            chart.Options.XAxis.ExtensionOptions.Add("panRange", new List<double> { -10, 10 });

            chart.Options.YAxis.ExtensionOptions.Add("zoomRange", new List<double> { 0.1, 10 });
            chart.Options.YAxis.ExtensionOptions.Add("panRange", new List<double> { -10, 10 });

            chart.Options.ExtensionOptions.Add("zoom", new { interactive = true });
            chart.Options.ExtensionOptions.Add("pan", new { interactive = true });

            return chart;
        }

        private Chart CreateInteractivityChart()
        {
            var chart = new Chart();
            var sin = new List<List<object>>();
            var cos = new List<List<object>>();

            for (var i = 0.0; i < 14; i += 0.5)
            {
                sin.Add(new List<object> { i, Math.Sin(i) });
                cos.Add(new List<object> { i, Math.Cos(i) });
            }
            var series = chart.AddDataSeries(sin, "sin(x)");
            series = chart.AddDataSeries(cos, "cos(x)");



            chart.Options.Lines.Show = true;
            chart.Options.Points.Show = true;
            chart.Options.Grid.Hoverable = true;
            chart.Options.Grid.Clickable = true;

            chart.Options.YAxis.Min = -1.2;
            chart.Options.YAxis.Max = 1.2;

            return chart;
        }

        private Chart CreateSelectionAndZoomingChart()
        {
            var chart = new Chart();

            var d1 = new List<List<object>>();
            var x1 = 0;
            var x2 = 3 * Math.PI;
            for (var i = 0; i <= 100; ++i)
            {
                var x = x1 + i * (x2 - x1) / 100;
                d1.Add(new List<Object> { x, Math.Sin(x * Math.Sin(x)) });
            }

            var series = chart.AddDataSeries(d1, "sin(x sin(x))");


            chart.Options.Lines.Show = true;
            chart.Options.Points.Show = true;
            chart.Options.Legend.Show = false;

            chart.Options.XAxis.TickDecimals = 0;

            chart.Options.YAxis.SetTicks(10);

            chart.Options.ExtensionOptions.Add("selection", new { mode = "xy" });

            return chart;
        }

        private Chart CreateSelectionChart()
        {
            var chart = new Chart();

            var data = new List<List<object>> { new List<object> { 1990, 18.9 }, new List<object> { 1991, 18.7 }, new List<object> { 1992, 18.4 }, new List<object> { 1993, 19.3 }, new List<object> { 1994, 19.5 }, new List<object> { 1995, 19.3 }, new List<object> { 1996, 19.4 }, new List<object> { 1997, 20.2 }, new List<object> { 1998, 19.8 }, new List<object> { 1999, 19.9 }, new List<object> { 2000, 20.4 }, new List<object> { 2001, 20.1 }, new List<object> { 2002, 20.0 }, new List<object> { 2003, 19.8 }, new List<object> { 2004, 20.4 } };
            var series = chart.AddDataSeries(data, "United States");

            data = new List<List<object>> { new List<object> { 1992, 13.4 }, new List<object> { 1993, 12.2 }, new List<object> { 1994, 10.6 }, new List<object> { 1995, 10.2 }, new List<object> { 1996, 10.1 }, new List<object> { 1997, 9.7 }, new List<object> { 1998, 9.5 }, new List<object> { 1999, 9.7 }, new List<object> { 2000, 9.9 }, new List<object> { 2001, 9.9 }, new List<object> { 2002, 9.9 }, new List<object> { 2003, 10.3 }, new List<object> { 2004, 10.5 } };
            series = chart.AddDataSeries(data, "Russia");

            data = new List<List<object>> { new List<object> { 1990, 10.0 }, new List<object> { 1991, 11.3 }, new List<object> { 1992, 9.9 }, new List<object> { 1993, 9.6 }, new List<object> { 1994, 9.5 }, new List<object> { 1995, 9.5 }, new List<object> { 1996, 9.9 }, new List<object> { 1997, 9.3 }, new List<object> { 1998, 9.2 }, new List<object> { 1999, 9.2 }, new List<object> { 2000, 9.5 }, new List<object> { 2001, 9.6 }, new List<object> { 2002, 9.3 }, new List<object> { 2003, 9.4 }, new List<object> { 2004, 9.79 } };
            series = chart.AddDataSeries(data, "United Kingdom");

            data = new List<List<object>> { new List<object> { 1990, 12.4 }, new List<object> { 1991, 11.2 }, new List<object> { 1992, 10.8 }, new List<object> { 1993, 10.5 }, new List<object> { 1994, 10.4 }, new List<object> { 1995, 10.2 }, new List<object> { 1996, 10.5 }, new List<object> { 1997, 10.2 }, new List<object> { 1998, 10.1 }, new List<object> { 1999, 9.6 }, new List<object> { 2000, 9.7 }, new List<object> { 2001, 10.0 }, new List<object> { 2002, 9.7 }, new List<object> { 2003, 9.8 }, new List<object> { 2004, 9.79 } };
            series = chart.AddDataSeries(data, "Germany");

            data = new List<List<object>> { new List<object> { 1990, 9.7 }, new List<object> { 1991, 12.1 }, new List<object> { 1992, 10.3 }, new List<object> { 1993, 11.3 }, new List<object> { 1994, 11.7 }, new List<object> { 1995, 10.6 }, new List<object> { 1996, 12.8 }, new List<object> { 1997, 10.8 }, new List<object> { 1998, 10.3 }, new List<object> { 1999, 9.4 }, new List<object> { 2000, 8.7 }, new List<object> { 2001, 9.0 }, new List<object> { 2002, 8.9 }, new List<object> { 2003, 10.1 }, new List<object> { 2004, 9.80 } };
            series = chart.AddDataSeries(data, "Denmark");

            data = new List<List<object>> { new List<object> { 1990, 5.8 }, new List<object> { 1991, 6.0 }, new List<object> { 1992, 5.9 }, new List<object> { 1993, 5.5 }, new List<object> { 1994, 5.7 }, new List<object> { 1995, 5.3 }, new List<object> { 1996, 6.1 }, new List<object> { 1997, 5.4 }, new List<object> { 1998, 5.4 }, new List<object> { 1999, 5.1 }, new List<object> { 2000, 5.2 }, new List<object> { 2001, 5.4 }, new List<object> { 2002, 6.2 }, new List<object> { 2003, 5.9 }, new List<object> { 2004, 5.89 } };
            series = chart.AddDataSeries(data, "Sweden");

            data = new List<List<object>> { new List<object> { 1990, 8.3 }, new List<object> { 1991, 8.3 }, new List<object> { 1992, 7.8 }, new List<object> { 1993, 8.3 }, new List<object> { 1994, 8.4 }, new List<object> { 1995, 5.9 }, new List<object> { 1996, 6.4 }, new List<object> { 1997, 6.7 }, new List<object> { 1998, 6.9 }, new List<object> { 1999, 7.6 }, new List<object> { 2000, 7.4 }, new List<object> { 2001, 8.1 }, new List<object> { 2002, 12.5 }, new List<object> { 2003, 9.9 }, new List<object> { 2004, 19.0 } };
            series = chart.AddDataSeries(data, "Norway");

            chart.Options.Lines.Show = true;
            chart.Options.Points.Show = true;
            chart.Options.Legend.NumberOfColumns = 2;

            chart.Options.XAxis.TickDecimals = 0;

            chart.Options.YAxis.Min = 0;

            chart.Options.ExtensionOptions.Add("selection", new { mode = "x" });

            return chart;
        }

        private Chart CreateAnnotationssChart()
        {
            var chart = new Chart();

            var d1 = new List<List<object>>();
            for (var i = 0; i < 20; ++i)
            {
                d1.Add(new List<object> { i, Math.Sin(i) });
            }

            var series = chart.AddDataSeries(d1, "Pressure", "#333");

            chart.Options.Bars.Show = true;
            chart.Options.Bars.BarWidth = 0.5;
            chart.Options.Bars.SetFill(0.9);

            chart.Options.XAxis.AutoscaleMargin = 0.02;
            chart.Options.XAxis.SetTicks(new List<List<object>>());

            chart.Options.YAxis.Min = -2;
            chart.Options.YAxis.Max = 2;


            chart.Options.Grid.Markings.Add(new Markings { Color = "#f6f6f6", YAxis = new MarkingsAxis { From = 1 } });
            chart.Options.Grid.Markings.Add(new Markings { Color = "#f6f6f6", YAxis = new MarkingsAxis { To = -1 } });
            chart.Options.Grid.Markings.Add(new Markings { Color = "#000", LineWidth = 1, XAxis = new MarkingsAxis { From = 2, To = 2 } });
            chart.Options.Grid.Markings.Add(new Markings { Color = "#000", LineWidth = 1, XAxis = new MarkingsAxis { From = 8, To = 8 } });

            return chart;
        }

        private Chart CreateBasicOptionsChart()
        {
            var chart = new Chart();

            var d1 = new List<List<object>>();
            for (var i = 0.0; i < Math.PI * 2; i += 0.25)
            {
                d1.Add(new List<object> { i, Math.Sin(i) });
            }
            var series = chart.AddDataSeries(d1, "sin(x)");

            var d2 = new List<List<object>>();
            for (var i = 0.0; i < Math.PI * 2; i += 0.25)
            {
                d2.Add(new List<object> { i, Math.Cos(i) });
            }
            series = chart.AddDataSeries(d2, "cos(x)");

            var d3 = new List<List<object>>();
            for (var i = 0.0; i < Math.PI * 2; i += 0.1)
            {
                d3.Add(new List<object> { i, Math.Tan(i) });
            }
            series = chart.AddDataSeries(d3, "tan(x)");

            chart.Options.Series.Lines.Show = true;
            chart.Options.Series.Points.Show = true;
            chart.Options.XAxis.SetTicks(
                        new Tick { 0 }, new Tick { Math.PI / 2, "\u03c0/2" }, new Tick { Math.PI, "\u03c0" },
                        new Tick { Math.PI * 3 / 2, "3\u03c0/2" }, new Tick { Math.PI * 2, "2\u03c0" }
                    );
            chart.Options.YAxis.SetTicks(10);
            chart.Options.YAxis.Min = -2;
            chart.Options.YAxis.Max = 2;
            chart.Options.YAxis.TickDecimals = 3;
            chart.Options.Grid.SetBackgroundColor("#fff", "#eee");
            chart.Options.Grid.SetBorderWidth(1, 1, 2, 2);

            return chart;
        }

        private Chart CreateCategoriesChart()
        {
            var chart = new Chart();
            var d1 = new List<List<object>>() { new List<object> { "January", 10 }, new List<object> { "February", 8 }, new List<object> { "March", 4 }, new List<object> { "April", 13 }, new List<object> { "May", 17 }, new List<object> { "June", 9 } };

            var series = chart.AddDataSeries(d1);
            chart.Options.Bars.Show = true;
            chart.Options.Bars.BarWidth = 0.6;
            chart.Options.Bars.Align = "center";

            chart.Options.XAxis.Mode = "categories";
            chart.Options.XAxis.TickLength = 0;
            return chart;
        }

        private Chart CreateSeriesTypesChart()
        {
            var chart = new Chart();

            var d1 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.5)
            {
                d1.Add(new List<object> { i, Math.Sin(i) });
            }
            var series = chart.AddDataSeries(d1);
            series.Lines.Show = true;
            series.Lines.SetFill(true);

            var d2 = new List<List<object>> { new List<object> { 0, 3 }, new List<object> { 4, 8 }, new List<object> { 8, 5 }, new List<object> { 9, 13 } };
            series = chart.AddDataSeries(d2);
            series.Bars.Show = true;

            var d3 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.5)
            {
                d3.Add(new List<object> { i, Math.Cos(i) });
            }
            series = chart.AddDataSeries(d3);
            series.Points.Show = true;

            var d4 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.1)
            {
                d4.Add(new List<object> { i, Math.Sqrt(i * 10) });
            }
            series = chart.AddDataSeries(d4);
            series.Lines.Show = true;

            var d5 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.5)
            {
                d5.Add(new List<object> { i, Math.Sqrt(i) });
            }
            series = chart.AddDataSeries(d5);
            series.Lines.Show = true;
            series.Points.Show = true;

            var random = new Random();
            var d6 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.5 + random.NextDouble())
            {
                d6.Add(new List<object> { i, Math.Sqrt(2 * i + Math.Sin(i) + 5) });
            }
            series = chart.AddDataSeries(d6);
            series.Lines.Show = true;
            series.Lines.Steps = true;

            return chart;
        }

        private Chart CreateBasicChart()
        {
            var chart = new Chart();

            var d1 = new List<List<object>>();
            for (var i = 0.0; i < 14; i += 0.5)
            {
                d1.Add(new List<object> { i, Math.Sin(i) });
            }
            chart.AddDataSeries(d1);

            var d2 = new List<List<object>> { new List<object> { 0, 3 }, new List<object> { 4, 8 }, new List<object> { 8, 5 }, new List<object> { 9, 13 } };
            chart.AddDataSeries(d2);

            // A null signifies separate line segments
            var d3 = new List<List<object>> { new List<object> { 0, 12 }, new List<object> { 7, 12 }, null, new List<object> { 7, 2.5 }, new List<object> { 12, 2.5 } };
            chart.AddDataSeries(d3);

            return chart;

        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}