using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalog.Pages
{
    public class DataGridPage : UserControl
    {
        public DataGridPage()
        {
            Collection = new ObservableCollection<CollectionItem>
            {
                new CollectionItem
                {
                    ID = 80894,
                    Name = "ligula",
                    Description = "velit. Sed malesuada",
                    Date = DateTime.Parse("2017.03.26"),
                    InStock = false,
                    Weight = -0.29,
                    Quantity = 471,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 22339,
                    Name = "lobortis",
                    Description = "malesuada vel, venenatis vel, faucibus id, libero. Donec",
                    Date = DateTime.Parse("2017.05.10"),
                    InStock = true,
                    Weight = 0.14,
                    Quantity = 356,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 97374,
                    Name = "neque.",
                    Description = "suscipit, est ac facilisis facilisis, magna tellus faucibus",
                    Date = DateTime.Parse("2018.05.07"),
                    InStock = true,
                    Weight = 0.35,
                    Quantity = 926,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 41617,
                    Name = "dui.",
                    Description = "consectetuer adipiscing elit. Aliquam",
                    Date = DateTime.Parse("2017.08.17"),
                    InStock = false,
                    Weight = -0.02,
                    Quantity = 66,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 48898,
                    Name = "metus.",
                    Description = "Vestibulum ut eros non enim",
                    Date = DateTime.Parse("2018.07.09"),
                    InStock = true,
                    Weight = 0.33,
                    Quantity = 152,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 52324,
                    Name = "diam.",
                    Description = "ac ipsum. Phasellus vitae",
                    Date = DateTime.Parse("2017.09.27"),
                    InStock = false,
                    Weight = 0.15,
                    Quantity = 419,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 61337,
                    Name = "iaculis",
                    Description = "dolor sit amet, consectetuer adipiscing elit. Curabitur",
                    Date = DateTime.Parse("2018.10.11"),
                    InStock = false,
                    Weight = -0.53,
                    Quantity = 886,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 81807,
                    Name = "id,",
                    Description = "sem semper erat, in consectetuer",
                    Date = DateTime.Parse("2018.03.20"),
                    InStock = false,
                    Weight = 0.01,
                    Quantity = 761,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 81576,
                    Name = "pede",
                    Description = "volutpat ornare, facilisis eget, ipsum. Donec",
                    Date = DateTime.Parse("2018.07.04"),
                    InStock = true,
                    Weight = -0.08,
                    Quantity = 965,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 60184,
                    Name = "Donec",
                    Description = "augue id ante dictum cursus. Nunc mauris elit,",
                    Date = DateTime.Parse("2018.09.19"),
                    InStock = false,
                    Weight = 0.23,
                    Quantity = 932,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 43370,
                    Name = "lacus.",
                    Description = "Donec non justo. Proin non massa non ante bibendum ullamcorper.",
                    Date = DateTime.Parse("2018.12.23"),
                    InStock = false,
                    Weight = -0.04,
                    Quantity = 235,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 39049,
                    Name = "lacus.",
                    Description = "Cum sociis natoque penatibus et magnis dis parturient montes,",
                    Date = DateTime.Parse("2018.12.12"),
                    InStock = false,
                    Weight = 0.02,
                    Quantity = 234,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 54953,
                    Name = "lobortis",
                    Description = "ullamcorper, velit in aliquet lobortis,",
                    Date = DateTime.Parse("2018.01.21"),
                    InStock = true,
                    Weight = -0.03,
                    Quantity = 309,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 83591,
                    Name = "Nunc",
                    Description = "eu, ligula. Aenean euismod",
                    Date = DateTime.Parse("2018.06.07"),
                    InStock = false,
                    Weight = -0.3,
                    Quantity = 122,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 81714,
                    Name = "vulputate",
                    Description = "Cras eget nisi dictum augue malesuada malesuada. Integer",
                    Date = DateTime.Parse("2018.05.27"),
                    InStock = false,
                    Weight = -0.47,
                    Quantity = 7,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 76933,
                    Name = "dictum",
                    Description = "amet risus. Donec egestas. Aliquam nec",
                    Date = DateTime.Parse("2017.09.26"),
                    InStock = false,
                    Weight = -0.26,
                    Quantity = 145,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 85424,
                    Name = "lorem",
                    Description = "molestie tellus. Aenean egestas hendrerit neque. In ornare",
                    Date = DateTime.Parse("2017.03.22"),
                    InStock = true,
                    Weight = 0.32,
                    Quantity = 646,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 30865,
                    Name = "massa.",
                    Description = "semper rutrum. Fusce dolor quam, elementum at, egestas a,",
                    Date = DateTime.Parse("2018.08.24"),
                    InStock = false,
                    Weight = 0.25,
                    Quantity = 242,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 34735,
                    Name = "sem",
                    Description = "Proin mi. Aliquam",
                    Date = DateTime.Parse("2017.04.18"),
                    InStock = true,
                    Weight = -0.31,
                    Quantity = 5,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 36919,
                    Name = "sed",
                    Description = "ligula. Aliquam erat volutpat.",
                    Date = DateTime.Parse("2017.03.10"),
                    InStock = true,
                    Weight = 0.02,
                    Quantity = 28,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 88134,
                    Name = "feugiat",
                    Description = "tellus non magna. Nam ligula",
                    Date = DateTime.Parse("2018.08.22"),
                    InStock = false,
                    Weight = -0.07,
                    Quantity = 9,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 64476,
                    Name = "vitae",
                    Description = "gravida. Aliquam tincidunt, nunc ac mattis ornare,",
                    Date = DateTime.Parse("2017.09.08"),
                    InStock = false,
                    Weight = -0.08,
                    Quantity = 783,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 53820,
                    Name = "Donec",
                    Description = "Phasellus at augue",
                    Date = DateTime.Parse("2017.10.12"),
                    InStock = true,
                    Weight = -0.47,
                    Quantity = 32,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 96054,
                    Name = "justo",
                    Description = "ante. Vivamus non",
                    Date = DateTime.Parse("2017.03.12"),
                    InStock = false,
                    Weight = -0.24,
                    Quantity = 335,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 84413,
                    Name = "tortor.",
                    Description = "mollis dui, in sodales elit",
                    Date = DateTime.Parse("2018.12.10"),
                    InStock = false,
                    Weight = -0.09,
                    Quantity = 885,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 63950,
                    Name = "tincidunt,",
                    Description = "erat. Sed nunc est, mollis",
                    Date = DateTime.Parse("2018.05.21"),
                    InStock = true,
                    Weight = 0.1,
                    Quantity = 193,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 25698,
                    Name = "arcu",
                    Description = "Sed congue, elit sed consequat auctor, nunc nulla",
                    Date = DateTime.Parse("2018.05.16"),
                    InStock = false,
                    Weight = 0.35,
                    Quantity = 155,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 84851,
                    Name = "dapibus",
                    Description = "sem eget massa. Suspendisse eleifend. Cras sed leo.",
                    Date = DateTime.Parse("2017.12.15"),
                    InStock = true,
                    Weight = 0.13,
                    Quantity = 878,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 95891,
                    Name = "Duis",
                    Description = "ridiculus mus. Proin vel",
                    Date = DateTime.Parse("2018.11.27"),
                    InStock = false,
                    Weight = 0.08,
                    Quantity = 321,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 11005,
                    Name = "egestas.",
                    Description = "ultrices sit amet, risus. Donec",
                    Date = DateTime.Parse("2018.01.18"),
                    InStock = false,
                    Weight = -0.54,
                    Quantity = 336,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 69833,
                    Name = "massa",
                    Description = "nunc id enim. Curabitur",
                    Date = DateTime.Parse("2018.01.03"),
                    InStock = true,
                    Weight = -0.19,
                    Quantity = 296,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 75247,
                    Name = "sit",
                    Description = "est arcu ac orci. Ut semper pretium",
                    Date = DateTime.Parse("2018.02.03"),
                    InStock = false,
                    Weight = -0.25,
                    Quantity = 32,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 13833,
                    Name = "mi",
                    Description = "fringilla. Donec feugiat metus sit amet",
                    Date = DateTime.Parse("2018.07.23"),
                    InStock = false,
                    Weight = 0.15,
                    Quantity = 612,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 39076,
                    Name = "adipiscing",
                    Description = "ante ipsum primis in faucibus orci luctus et ultrices posuere",
                    Date = DateTime.Parse("2019.01.15"),
                    InStock = false,
                    Weight = -0.35,
                    Quantity = 455,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 43345,
                    Name = "nibh",
                    Description = "In at pede.",
                    Date = DateTime.Parse("2018.07.30"),
                    InStock = false,
                    Weight = -0.2,
                    Quantity = 656,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 43029,
                    Name = "senectus",
                    Description = "Morbi quis urna. Nunc quis arcu vel",
                    Date = DateTime.Parse("2019.02.23"),
                    InStock = true,
                    Weight = -0.39,
                    Quantity = 432,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 19561,
                    Name = "amet,",
                    Description = "eu, ligula. Aenean euismod mauris",
                    Date = DateTime.Parse("2017.04.16"),
                    InStock = true,
                    Weight = 0.05,
                    Quantity = 645,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 60007,
                    Name = "Curae;",
                    Description = "turpis. In condimentum. Donec at arcu. Vestibulum ante",
                    Date = DateTime.Parse("2018.11.25"),
                    InStock = true,
                    Weight = -0.14,
                    Quantity = 836,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 12994,
                    Name = "erat",
                    Description = "arcu. Sed eu nibh vulputate mauris sagittis",
                    Date = DateTime.Parse("2017.06.13"),
                    InStock = false,
                    Weight = 0.49,
                    Quantity = 571,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 57261,
                    Name = "nascetur",
                    Description = "pretium et, rutrum",
                    Date = DateTime.Parse("2017.03.03"),
                    InStock = false,
                    Weight = 0.01,
                    Quantity = 779,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 45106,
                    Name = "est.",
                    Description = "mi. Duis risus odio, auctor vitae,",
                    Date = DateTime.Parse("2018.02.13"),
                    InStock = false,
                    Weight = -0.21,
                    Quantity = 69,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 45552,
                    Name = "mollis.",
                    Description = "neque vitae semper egestas, urna justo faucibus lectus, a",
                    Date = DateTime.Parse("2017.05.27"),
                    InStock = false,
                    Weight = 0.15,
                    Quantity = 428,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 47766,
                    Name = "natoque",
                    Description = "nec metus facilisis lorem tristique aliquet.",
                    Date = DateTime.Parse("2018.04.23"),
                    InStock = true,
                    Weight = -0.01,
                    Quantity = 792,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 30903,
                    Name = "augue,",
                    Description = "Donec nibh. Quisque nonummy ipsum non",
                    Date = DateTime.Parse("2017.06.28"),
                    InStock = false,
                    Weight = 0.03,
                    Quantity = 533,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 46309,
                    Name = "magna.",
                    Description = "ultricies sem magna nec quam.",
                    Date = DateTime.Parse("2017.06.12"),
                    InStock = true,
                    Weight = 0.47,
                    Quantity = 166,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 65888,
                    Name = "natoque",
                    Description = "ridiculus mus. Donec dignissim magna a tortor. Nunc commodo",
                    Date = DateTime.Parse("2018.02.20"),
                    InStock = true,
                    Weight = 0.32,
                    Quantity = 539,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 84928,
                    Name = "mollis.",
                    Description = "tellus eu augue porttitor interdum. Sed",
                    Date = DateTime.Parse("2017.06.26"),
                    InStock = false,
                    Weight = -0.33,
                    Quantity = 161,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 84614,
                    Name = "Pellentesque",
                    Description = "a, malesuada id, erat. Etiam",
                    Date = DateTime.Parse("2017.03.30"),
                    InStock = false,
                    Weight = 0.22,
                    Quantity = 587,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 13768,
                    Name = "nec",
                    Description = "Praesent interdum ligula eu enim. Etiam imperdiet dictum magna.",
                    Date = DateTime.Parse("2018.05.26"),
                    InStock = true,
                    Weight = -0.21,
                    Quantity = 756,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 11728,
                    Name = "quis",
                    Description = "sociis natoque penatibus et magnis dis parturient montes, nascetur",
                    Date = DateTime.Parse("2017.06.20"),
                    InStock = true,
                    Weight = -0.28,
                    Quantity = 204,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 96256,
                    Name = "non",
                    Description = "mi fringilla mi",
                    Date = DateTime.Parse("2017.04.03"),
                    InStock = true,
                    Weight = -0.34,
                    Quantity = 21,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 88615,
                    Name = "Proin",
                    Description = "nonummy ipsum non arcu. Vivamus sit",
                    Date = DateTime.Parse("2017.05.24"),
                    InStock = false,
                    Weight = 0.32,
                    Quantity = 327,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 82840,
                    Name = "auctor",
                    Description = "volutpat nunc sit amet metus. Aliquam",
                    Date = DateTime.Parse("2018.09.02"),
                    InStock = false,
                    Weight = 0.21,
                    Quantity = 466,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 48696,
                    Name = "malesuada",
                    Description = "nunc est, mollis non, cursus",
                    Date = DateTime.Parse("2017.08.05"),
                    InStock = true,
                    Weight = -0.12,
                    Quantity = 231,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 92429,
                    Name = "ac",
                    Description = "egestas a, dui. Cras pellentesque.",
                    Date = DateTime.Parse("2017.05.14"),
                    InStock = false,
                    Weight = -0.08,
                    Quantity = 153,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 38314,
                    Name = "turpis",
                    Description = "non, dapibus rutrum, justo. Praesent luctus. Curabitur",
                    Date = DateTime.Parse("2018.07.26"),
                    InStock = true,
                    Weight = 0.86,
                    Quantity = 980,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 81565,
                    Name = "consectetuer",
                    Description = "Nulla facilisi. Sed neque. Sed",
                    Date = DateTime.Parse("2018.10.24"),
                    InStock = true,
                    Weight = 0.05,
                    Quantity = 416,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 41818,
                    Name = "orci",
                    Description = "ligula elit, pretium et, rutrum",
                    Date = DateTime.Parse("2018.02.25"),
                    InStock = false,
                    Weight = -0.12,
                    Quantity = 319,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 39956,
                    Name = "neque",
                    Description = "vitae aliquam eros turpis non",
                    Date = DateTime.Parse("2018.03.10"),
                    InStock = false,
                    Weight = -0.03,
                    Quantity = 968,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 64443,
                    Name = "in",
                    Description = "in faucibus orci luctus et ultrices posuere",
                    Date = DateTime.Parse("2017.11.23"),
                    InStock = true,
                    Weight = -0.06,
                    Quantity = 859,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 25090,
                    Name = "Sed",
                    Description = "mauris. Integer sem",
                    Date = DateTime.Parse("2018.05.01"),
                    InStock = true,
                    Weight = -0.03,
                    Quantity = 350,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 86573,
                    Name = "sem",
                    Description = "Praesent luctus. Curabitur egestas nunc sed",
                    Date = DateTime.Parse("2018.11.16"),
                    InStock = false,
                    Weight = -0.16,
                    Quantity = 22,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 11523,
                    Name = "Nam",
                    Description = "enim non nisi. Aenean eget metus.",
                    Date = DateTime.Parse("2018.01.04"),
                    InStock = true,
                    Weight = -0.03,
                    Quantity = 85,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 80616,
                    Name = "natoque",
                    Description = "nunc id enim. Curabitur",
                    Date = DateTime.Parse("2018.11.06"),
                    InStock = true,
                    Weight = 0,
                    Quantity = 925,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 59838,
                    Name = "ultrices",
                    Description = "erat nonummy ultricies",
                    Date = DateTime.Parse("2017.12.03"),
                    InStock = true,
                    Weight = -0.3,
                    Quantity = 486,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 35174,
                    Name = "sodales",
                    Description = "ut lacus. Nulla tincidunt, neque",
                    Date = DateTime.Parse("2017.07.30"),
                    InStock = false,
                    Weight = -0.18,
                    Quantity = 531,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 81253,
                    Name = "a,",
                    Description = "libero nec ligula",
                    Date = DateTime.Parse("2017.03.24"),
                    InStock = true,
                    Weight = -0.18,
                    Quantity = 141,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 49365,
                    Name = "mollis.",
                    Description = "natoque penatibus et",
                    Date = DateTime.Parse("2017.03.16"),
                    InStock = false,
                    Weight = -0.08,
                    Quantity = 617,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 37896,
                    Name = "ac",
                    Description = "aliquet. Phasellus fermentum convallis ligula. Donec",
                    Date = DateTime.Parse("2017.04.08"),
                    InStock = false,
                    Weight = 0.15,
                    Quantity = 565,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 75403,
                    Name = "ridiculus",
                    Description = "odio vel est tempor bibendum. Donec felis orci, adipiscing",
                    Date = DateTime.Parse("2018.02.17"),
                    InStock = false,
                    Weight = -0.1,
                    Quantity = 702,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 90610,
                    Name = "elit",
                    Description = "natoque penatibus et magnis dis parturient",
                    Date = DateTime.Parse("2018.09.28"),
                    InStock = true,
                    Weight = 0.06,
                    Quantity = 977,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 65672,
                    Name = "risus.",
                    Description = "cursus. Integer mollis. Integer tincidunt aliquam arcu. Aliquam",
                    Date = DateTime.Parse("2017.02.26"),
                    InStock = false,
                    Weight = 0.6,
                    Quantity = 829,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 92828,
                    Name = "Praesent",
                    Description = "sit amet ultricies sem magna nec quam. Curabitur",
                    Date = DateTime.Parse("2018.01.16"),
                    InStock = true,
                    Weight = 0.17,
                    Quantity = 709,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 28542,
                    Name = "commodo",
                    Description = "Nam ac nulla. In tincidunt",
                    Date = DateTime.Parse("2018.11.29"),
                    InStock = true,
                    Weight = 0.1,
                    Quantity = 713,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 54447,
                    Name = "malesuada",
                    Description = "et, rutrum non, hendrerit id, ante.",
                    Date = DateTime.Parse("2017.04.06"),
                    InStock = false,
                    Weight = -0.3,
                    Quantity = 856,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 67356,
                    Name = "amet,",
                    Description = "luctus et ultrices posuere cubilia Curae; Donec tincidunt. Donec",
                    Date = DateTime.Parse("2018.06.03"),
                    InStock = false,
                    Weight = 0.07,
                    Quantity = 7,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 80716,
                    Name = "in",
                    Description = "Aliquam adipiscing lobortis risus. In mi pede,",
                    Date = DateTime.Parse("2018.12.28"),
                    InStock = false,
                    Weight = 0.48,
                    Quantity = 649,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 36438,
                    Name = "erat",
                    Description = "primis in faucibus orci luctus",
                    Date = DateTime.Parse("2018.05.19"),
                    InStock = false,
                    Weight = 0.12,
                    Quantity = 955,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 51587,
                    Name = "auctor",
                    Description = "velit eget laoreet posuere, enim nisl elementum purus, accumsan interdum",
                    Date = DateTime.Parse("2017.10.29"),
                    InStock = false,
                    Weight = -0.08,
                    Quantity = 606,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 94755,
                    Name = "id,",
                    Description = "vitae aliquam eros turpis",
                    Date = DateTime.Parse("2018.02.20"),
                    InStock = false,
                    Weight = -0.35,
                    Quantity = 168,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 46847,
                    Name = "et,",
                    Description = "luctus ut, pellentesque eget,",
                    Date = DateTime.Parse("2018.11.18"),
                    InStock = false,
                    Weight = -0.22,
                    Quantity = 38,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 85643,
                    Name = "sem",
                    Description = "magna. Sed eu eros. Nam",
                    Date = DateTime.Parse("2017.06.29"),
                    InStock = false,
                    Weight = -0.03,
                    Quantity = 404,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 85739,
                    Name = "id",
                    Description = "dolor sit amet, consectetuer adipiscing elit. Etiam laoreet, libero",
                    Date = DateTime.Parse("2018.09.08"),
                    InStock = false,
                    Weight = 0.18,
                    Quantity = 968,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 20843,
                    Name = "tincidunt,",
                    Description = "nulla. Integer urna. Vivamus molestie dapibus",
                    Date = DateTime.Parse("2018.12.24"),
                    InStock = true,
                    Weight = -0.03,
                    Quantity = 768,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 45147,
                    Name = "aliquam,",
                    Description = "urna suscipit nonummy. Fusce fermentum fermentum",
                    Date = DateTime.Parse("2019.01.25"),
                    InStock = false,
                    Weight = 0.07,
                    Quantity = 16,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 99587,
                    Name = "eget",
                    Description = "ipsum dolor sit amet, consectetuer adipiscing elit. Etiam laoreet, libero",
                    Date = DateTime.Parse("2018.03.31"),
                    InStock = false,
                    Weight = -0.07,
                    Quantity = 18,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 46540,
                    Name = "amet",
                    Description = "fringilla ornare placerat,",
                    Date = DateTime.Parse("2017.05.16"),
                    InStock = false,
                    Weight = 0.08,
                    Quantity = 434,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 32685,
                    Name = "vitae,",
                    Description = "nisl arcu iaculis enim, sit amet ornare",
                    Date = DateTime.Parse("2018.11.21"),
                    InStock = true,
                    Weight = -0.03,
                    Quantity = 23,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 42702,
                    Name = "at,",
                    Description = "accumsan neque et nunc. Quisque ornare tortor at",
                    Date = DateTime.Parse("2018.10.10"),
                    InStock = true,
                    Weight = 0.01,
                    Quantity = 681,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 59045,
                    Name = "nunc",
                    Description = "Proin sed turpis nec mauris",
                    Date = DateTime.Parse("2018.12.04"),
                    InStock = true,
                    Weight = -0.12,
                    Quantity = 198,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 65839,
                    Name = "posuere",
                    Description = "Donec felis orci, adipiscing non, luctus sit amet, faucibus",
                    Date = DateTime.Parse("2018.05.19"),
                    InStock = false,
                    Weight = -0.12,
                    Quantity = 27,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 18102,
                    Name = "nostra,",
                    Description = "Suspendisse sagittis. Nullam vitae",
                    Date = DateTime.Parse("2019.02.08"),
                    InStock = true,
                    Weight = 0.42,
                    Quantity = 689,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 44263,
                    Name = "varius",
                    Description = "lorem eu metus. In",
                    Date = DateTime.Parse("2018.12.01"),
                    InStock = true,
                    Weight = 0.21,
                    Quantity = 404,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 48348,
                    Name = "Nullam",
                    Description = "mollis non, cursus",
                    Date = DateTime.Parse("2018.08.10"),
                    InStock = true,
                    Weight = 0.45,
                    Quantity = 388,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 17754,
                    Name = "ut,",
                    Description = "placerat. Cras dictum ultricies",
                    Date = DateTime.Parse("2019.02.01"),
                    InStock = true,
                    Weight = 0.43,
                    Quantity = 533,
                    Condition = Condition.Broken
                },
                new CollectionItem
                {
                    ID = 89592,
                    Name = "Nunc",
                    Description = "egestas rhoncus. Proin",
                    Date = DateTime.Parse("2019.02.24"),
                    InStock = true,
                    Weight = -0.35,
                    Quantity = 377,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 84142,
                    Name = "dui,",
                    Description = "sed, est. Nunc laoreet lectus quis massa.",
                    Date = DateTime.Parse("2017.08.20"),
                    InStock = true,
                    Weight = 0.13,
                    Quantity = 82,
                    Condition = Condition.Restored
                },
                new CollectionItem
                {
                    ID = 50661,
                    Name = "gravida.",
                    Description = "Sed id risus",
                    Date = DateTime.Parse("2018.09.05"),
                    InStock = false,
                    Weight = 0.15,
                    Quantity = 557,
                    Condition = Condition.New
                },
                new CollectionItem
                {
                    ID = 12464,
                    Name = "ligula",
                    Description = "auctor velit. Aliquam nisl. Nulla eu neque pellentesque",
                    Date = DateTime.Parse("2018.12.19"),
                    InStock = false,
                    Weight = -0.31,
                    Quantity = 621,
                    Condition = Condition.Used
                },
                new CollectionItem
                {
                    ID = 88630,
                    Name = "amet,",
                    Description = "at fringilla purus mauris a",
                    Date = DateTime.Parse("2018.03.05"),
                    InStock = false,
                    Weight = 0.25,
                    Quantity = 818,
                    Condition = Condition.Used
                }
            };

            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public ObservableCollection<CollectionItem> Collection { get; }

        public class CollectionItem
        {
            public long ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public DateTime? Date { get; set; }

            public bool InStock { get; set; }

            public double Weight { get; set; }

            public int Quantity { get; set; }

            public Condition Condition { get; set; }
        }

        public enum Condition
        {
            New,
            Restored,
            Used,
            Broken
        }
    }
}
