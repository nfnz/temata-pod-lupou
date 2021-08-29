﻿using TemataPodLupou.Web.Models;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Routing;

namespace TemataPodLupou.Web.ContentFinders
{
    public class SubmissionWidgetHostScriptFinder : AlternativeTemplateContentFinder
    {
        protected override string TemplateAlias => "SubmissionWidgetScriptEmbed";
        protected override string DocTypeAlias => SubmissionWidget.ModelTypeAlias;
        protected override string UrlSlug => "embed";

        [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
        public class Composer : IUserComposer
        {
            public void Compose(Composition composition)
            {
                composition.ContentFinders().InsertBefore<ContentFinderByUrl, SubmissionWidgetHostScriptFinder>();
            }
        }

        public SubmissionWidgetHostScriptFinder(ILogger logger, IFileService fileService)
            : base(logger, fileService) { }
    }
}