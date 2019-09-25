﻿using Our.Umbraco.ExamineConfig.Helpers;

namespace Our.Umbraco.ExamineConfig.Configuration
{
    public class ExamineIndexConfig
    {
        public ExamineIndexConfig(string indexName)
        {
            ParentId = ConfigHelper.ParentId(indexName);
            IncludeItemTypes = ConfigHelper.IncludeItemTypes(indexName);
            ExcludeItemTypes = ConfigHelper.ExcludeItemTypes(indexName);
            SupportProtectedContent = ConfigHelper.SupportProtectedContent(indexName);
        }

        public int? ParentId { get; private set; }

        public string[] IncludeItemTypes { get; private set; }

        public string[] ExcludeItemTypes { get; private set; }

        public bool SupportProtectedContent { get; private set; }
    }
}