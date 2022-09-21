﻿namespace AspBetSample.DataBase.Entities
{
    public class Article : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullText { get; set; }
        public DateTime PublicationDate { get; set; }

        public Guid SourceId { get; set; }
        public Source Source{ get; set; }

        public List<Comment> Comments { get; set; }
    }
}