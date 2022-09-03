using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core
{
    public class ArticlesStorage
    {

        public readonly List<ArticleDto> ArticlesList;

        public ArticlesStorage()
        {
            ArticlesList = new()
            {
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra.",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem ante, lacinia laoreet purus et, rhoncus dictum magna. Donec arcu libero, fermentum sed iaculis sed, ornare in augue. Mauris consequat magna lacus, quis pretium ante commodo nec. Suspendisse facilisis sapien vel mi gravida accumsan. Quisque non viverra tortor, id pharetra nunc. Vivamus id nisl urna. Integer eu nunc lacinia, iaculis neque nec, pellentesque felis. Praesent vulputate mi eget finibus posuere. Suspendisse et sollicitudin urna, in molestie metus. Nulla maximus aliquet rhoncus. Donec non nibh vel mi convallis bibendum et ac erat. Suspendisse eleifend leo tellus, vel interdum leo tincidunt eget. Nam rutrum tortor vel orci sollicitudin bibendum. Praesent eget nunc a neque faucibus faucibus.\r\n\r\nEtiam libero ligula, vulputate nec neque quis, congue consectetur mauris. Sed bibendum nunc quis nunc vulputate eleifend. In nisi orci, volutpat id lectus tincidunt, luctus sagittis dui. Suspendisse potenti. Proin ultricies porta lorem, eget vehicula mauris ultrices et. Quisque in dapibus magna. Pellentesque nec magna at nisi hendrerit interdum et vitae velit. Pellentesque ipsum dolor, tristique a rhoncus nec, fringilla et velit. Quisque velit est, scelerisque id facilisis a, interdum non lorem. Fusce sollicitudin finibus suscipit. Etiam fermentum elementum imperdiet. Morbi imperdiet feugiat felis eu sodales.\r\n\r\nInteger porta porttitor ligula vel malesuada. Vivamus ultrices leo nec lacus aliquam, non aliquet velit congue. Aliquam sit amet porta elit. Praesent maximus molestie elit in mattis. Praesent nec turpis ut ante pretium condimentum. Nulla quam nisi, sodales quis enim vitae, aliquam venenatis ipsum. Mauris porta lobortis faucibus. Nunc varius sem ornare congue ultricies. Aenean eget mollis lectus."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra.",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem ante, lacinia laoreet purus et, rhoncus dictum magna. Donec arcu libero, fermentum sed iaculis sed, ornare in augue. Mauris consequat magna lacus, quis pretium ante commodo nec. Suspendisse facilisis sapien vel mi gravida accumsan. Quisque non viverra tortor, id pharetra nunc. Vivamus id nisl urna. Integer eu nunc lacinia, iaculis neque nec, pellentesque felis. Praesent vulputate mi eget finibus posuere. Suspendisse et sollicitudin urna, in molestie metus. Nulla maximus aliquet rhoncus. Donec non nibh vel mi convallis bibendum et ac erat. Suspendisse eleifend leo tellus, vel interdum leo tincidunt eget. Nam rutrum tortor vel orci sollicitudin bibendum. Praesent eget nunc a neque faucibus faucibus.\r\n\r\nEtiam libero ligula, vulputate nec neque quis, congue consectetur mauris. Sed bibendum nunc quis nunc vulputate eleifend. In nisi orci, volutpat id lectus tincidunt, luctus sagittis dui. Suspendisse potenti. Proin ultricies porta lorem, eget vehicula mauris ultrices et. Quisque in dapibus magna. Pellentesque nec magna at nisi hendrerit interdum et vitae velit. Pellentesque ipsum dolor, tristique a rhoncus nec, fringilla et velit. Quisque velit est, scelerisque id facilisis a, interdum non lorem. Fusce sollicitudin finibus suscipit. Etiam fermentum elementum imperdiet. Morbi imperdiet feugiat felis eu sodales.\r\n\r\nInteger porta porttitor ligula vel malesuada. Vivamus ultrices leo nec lacus aliquam, non aliquet velit congue. Aliquam sit amet porta elit. Praesent maximus molestie elit in mattis. Praesent nec turpis ut ante pretium condimentum. Nulla quam nisi, sodales quis enim vitae, aliquam venenatis ipsum. Mauris porta lobortis faucibus. Nunc varius sem ornare congue ultricies. Aenean eget mollis lectus."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra.",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem ante, lacinia laoreet purus et, rhoncus dictum magna. Donec arcu libero, fermentum sed iaculis sed, ornare in augue. Mauris consequat magna lacus, quis pretium ante commodo nec. Suspendisse facilisis sapien vel mi gravida accumsan. Quisque non viverra tortor, id pharetra nunc. Vivamus id nisl urna. Integer eu nunc lacinia, iaculis neque nec, pellentesque felis. Praesent vulputate mi eget finibus posuere. Suspendisse et sollicitudin urna, in molestie metus. Nulla maximus aliquet rhoncus. Donec non nibh vel mi convallis bibendum et ac erat. Suspendisse eleifend leo tellus, vel interdum leo tincidunt eget. Nam rutrum tortor vel orci sollicitudin bibendum. Praesent eget nunc a neque faucibus faucibus.\r\n\r\nEtiam libero ligula, vulputate nec neque quis, congue consectetur mauris. Sed bibendum nunc quis nunc vulputate eleifend. In nisi orci, volutpat id lectus tincidunt, luctus sagittis dui. Suspendisse potenti. Proin ultricies porta lorem, eget vehicula mauris ultrices et. Quisque in dapibus magna. Pellentesque nec magna at nisi hendrerit interdum et vitae velit. Pellentesque ipsum dolor, tristique a rhoncus nec, fringilla et velit. Quisque velit est, scelerisque id facilisis a, interdum non lorem. Fusce sollicitudin finibus suscipit. Etiam fermentum elementum imperdiet. Morbi imperdiet feugiat felis eu sodales.\r\n\r\nInteger porta porttitor ligula vel malesuada. Vivamus ultrices leo nec lacus aliquam, non aliquet velit congue. Aliquam sit amet porta elit. Praesent maximus molestie elit in mattis. Praesent nec turpis ut ante pretium condimentum. Nulla quam nisi, sodales quis enim vitae, aliquam venenatis ipsum. Mauris porta lobortis faucibus. Nunc varius sem ornare congue ultricies. Aenean eget mollis lectus."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra.",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem ante, lacinia laoreet purus et, rhoncus dictum magna. Donec arcu libero, fermentum sed iaculis sed, ornare in augue. Mauris consequat magna lacus, quis pretium ante commodo nec. Suspendisse facilisis sapien vel mi gravida accumsan. Quisque non viverra tortor, id pharetra nunc. Vivamus id nisl urna. Integer eu nunc lacinia, iaculis neque nec, pellentesque felis. Praesent vulputate mi eget finibus posuere. Suspendisse et sollicitudin urna, in molestie metus. Nulla maximus aliquet rhoncus. Donec non nibh vel mi convallis bibendum et ac erat. Suspendisse eleifend leo tellus, vel interdum leo tincidunt eget. Nam rutrum tortor vel orci sollicitudin bibendum. Praesent eget nunc a neque faucibus faucibus.\r\n\r\nEtiam libero ligula, vulputate nec neque quis, congue consectetur mauris. Sed bibendum nunc quis nunc vulputate eleifend. In nisi orci, volutpat id lectus tincidunt, luctus sagittis dui. Suspendisse potenti. Proin ultricies porta lorem, eget vehicula mauris ultrices et. Quisque in dapibus magna. Pellentesque nec magna at nisi hendrerit interdum et vitae velit. Pellentesque ipsum dolor, tristique a rhoncus nec, fringilla et velit. Quisque velit est, scelerisque id facilisis a, interdum non lorem. Fusce sollicitudin finibus suscipit. Etiam fermentum elementum imperdiet. Morbi imperdiet feugiat felis eu sodales.\r\n\r\nInteger porta porttitor ligula vel malesuada. Vivamus ultrices leo nec lacus aliquam, non aliquet velit congue. Aliquam sit amet porta elit. Praesent maximus molestie elit in mattis. Praesent nec turpis ut ante pretium condimentum. Nulla quam nisi, sodales quis enim vitae, aliquam venenatis ipsum. Mauris porta lobortis faucibus. Nunc varius sem ornare congue ultricies. Aenean eget mollis lectus."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra.",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem ante, lacinia laoreet purus et, rhoncus dictum magna. Donec arcu libero, fermentum sed iaculis sed, ornare in augue. Mauris consequat magna lacus, quis pretium ante commodo nec. Suspendisse facilisis sapien vel mi gravida accumsan. Quisque non viverra tortor, id pharetra nunc. Vivamus id nisl urna. Integer eu nunc lacinia, iaculis neque nec, pellentesque felis. Praesent vulputate mi eget finibus posuere. Suspendisse et sollicitudin urna, in molestie metus. Nulla maximus aliquet rhoncus. Donec non nibh vel mi convallis bibendum et ac erat. Suspendisse eleifend leo tellus, vel interdum leo tincidunt eget. Nam rutrum tortor vel orci sollicitudin bibendum. Praesent eget nunc a neque faucibus faucibus.\r\n\r\nEtiam libero ligula, vulputate nec neque quis, congue consectetur mauris. Sed bibendum nunc quis nunc vulputate eleifend. In nisi orci, volutpat id lectus tincidunt, luctus sagittis dui. Suspendisse potenti. Proin ultricies porta lorem, eget vehicula mauris ultrices et. Quisque in dapibus magna. Pellentesque nec magna at nisi hendrerit interdum et vitae velit. Pellentesque ipsum dolor, tristique a rhoncus nec, fringilla et velit. Quisque velit est, scelerisque id facilisis a, interdum non lorem. Fusce sollicitudin finibus suscipit. Etiam fermentum elementum imperdiet. Morbi imperdiet feugiat felis eu sodales.\r\n\r\nInteger porta porttitor ligula vel malesuada. Vivamus ultrices leo nec lacus aliquam, non aliquet velit congue. Aliquam sit amet porta elit. Praesent maximus molestie elit in mattis. Praesent nec turpis ut ante pretium condimentum. Nulla quam nisi, sodales quis enim vitae, aliquam venenatis ipsum. Mauris porta lobortis faucibus. Nunc varius sem ornare congue ultricies. Aenean eget mollis lectus."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
                new ArticleDto
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet.",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu auctor felis. Nunc eget enim tristique, eleifend urna nec, ullamcorper lectus. Ut erat nisl, ultrices eget ultricies non, pellentesque nec nibh. Nam egestas rutrum euismod. Vestibulum vitae sollicitudin sem. Duis sit amet metus justo. Quisque id volutpat eros. Proin nec leo augue. Aliquam facilisis elit nec risus iaculis, id blandit nisi viverra."
                },
            };
        }
    }
}
