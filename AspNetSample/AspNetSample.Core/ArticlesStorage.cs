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
