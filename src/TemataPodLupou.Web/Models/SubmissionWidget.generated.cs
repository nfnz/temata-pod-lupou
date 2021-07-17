//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.14.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace TemataPodLupou.Web.Models
{
	/// <summary>Submission Widget</summary>
	[PublishedModel("submissionWidget")]
	public partial class SubmissionWidget : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		public new const string ModelTypeAlias = "submissionWidget";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SubmissionWidget, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SubmissionWidget(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Back To Site Button Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("backToSiteButtonLabel")]
		public virtual string BackToSiteButtonLabel => this.Value<string>("backToSiteButtonLabel");

		///<summary>
		/// Collection Process
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("collectionProcess")]
		public virtual global::System.Collections.Generic.IEnumerable<global::TemataPodLupou.Web.Models.ProcessStep> CollectionProcess => this.Value<global::System.Collections.Generic.IEnumerable<global::TemataPodLupou.Web.Models.ProcessStep>>("collectionProcess");

		///<summary>
		/// Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("ctaButtonText")]
		public virtual string CtaButtonText => this.Value<string>("ctaButtonText");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("ctaHeading")]
		public virtual string CtaHeading => this.Value<string>("ctaHeading");

		///<summary>
		/// Description Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("descriptionFieldCaption")]
		public virtual string DescriptionFieldCaption => this.Value<string>("descriptionFieldCaption");

		///<summary>
		/// Description Field Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("descriptionFieldHelpText")]
		public virtual string DescriptionFieldHelpText => this.Value<string>("descriptionFieldHelpText");

		///<summary>
		/// Email Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("emailFieldCaption")]
		public virtual string EmailFieldCaption => this.Value<string>("emailFieldCaption");

		///<summary>
		/// Email Field Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("emailFieldHelpText")]
		public virtual string EmailFieldHelpText => this.Value<string>("emailFieldHelpText");

		///<summary>
		/// File Field Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("fileFieldCaption")]
		public virtual string FileFieldCaption => this.Value<string>("fileFieldCaption");

		///<summary>
		/// File Field Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("fileFieldHelpText")]
		public virtual string FileFieldHelpText => this.Value<string>("fileFieldHelpText");

		///<summary>
		/// File Field Selected Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("fileFieldSelectedLabel")]
		public virtual string FileFieldSelectedLabel => this.Value<string>("fileFieldSelectedLabel");

		///<summary>
		/// Form Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("formDescription")]
		public virtual string FormDescription => this.Value<string>("formDescription");

		///<summary>
		/// Media Store Folder
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("mediaStoreFolder")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops MediaStoreFolder => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("mediaStoreFolder");

		///<summary>
		/// Reason Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("reasonFieldCaption")]
		public virtual string ReasonFieldCaption => this.Value<string>("reasonFieldCaption");

		///<summary>
		/// Reason Field Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("reasonFieldHelpText")]
		public virtual string ReasonFieldHelpText => this.Value<string>("reasonFieldHelpText");

		///<summary>
		/// Region Dropdown Values
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("regionDropdownValues")]
		public virtual global::System.Collections.Generic.IEnumerable<string> RegionDropdownValues => this.Value<global::System.Collections.Generic.IEnumerable<string>>("regionDropdownValues");

		///<summary>
		/// Region Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("regionFieldCaption")]
		public virtual string RegionFieldCaption => this.Value<string>("regionFieldCaption");

		///<summary>
		/// Specific Location Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("specificLocationFieldCaption")]
		public virtual string SpecificLocationFieldCaption => this.Value<string>("specificLocationFieldCaption");

		///<summary>
		/// Specific Location Selector Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("specificLocationSelectorCaption")]
		public virtual string SpecificLocationSelectorCaption => this.Value<string>("specificLocationSelectorCaption");

		///<summary>
		/// Specific Location Selector - Specify Location Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("specificLocationSelectorSpecifyLocationLabel")]
		public virtual string SpecificLocationSelectorSpecifyLocationLabel => this.Value<string>("specificLocationSelectorSpecifyLocationLabel");

		///<summary>
		/// Specific Location Selector - Whole Region Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("specificLocationSelectorWholeRegionLabel")]
		public virtual string SpecificLocationSelectorWholeRegionLabel => this.Value<string>("specificLocationSelectorWholeRegionLabel");

		///<summary>
		/// Submit Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("submitButtonText")]
		public virtual string SubmitButtonText => this.Value<string>("submitButtonText");

		///<summary>
		/// Terms and Conditions
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("termsAndConditions")]
		public virtual string TermsAndConditions => this.Value<string>("termsAndConditions");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("thankYouImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops ThankYouImage => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("thankYouImage");

		///<summary>
		/// Thank You Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("thankYouText")]
		public virtual string ThankYouText => this.Value<string>("thankYouText");

		///<summary>
		/// Title Field Caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("titleFieldCaption")]
		public virtual string TitleFieldCaption => this.Value<string>("titleFieldCaption");

		///<summary>
		/// Title Field Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.14.0")]
		[ImplementPropertyType("titleFieldHelpText")]
		public virtual string TitleFieldHelpText => this.Value<string>("titleFieldHelpText");
	}
}