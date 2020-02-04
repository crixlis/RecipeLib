//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.5.2
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

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Recipe</summary>
	[PublishedModel("recipe")]
	public partial class Recipe : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		public new const string ModelTypeAlias = "recipe";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Recipe, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Recipe(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Description: How to make the dish
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("description")]
		public global::System.Web.IHtmlString Description => this.Value<global::System.Web.IHtmlString>("description");

		///<summary>
		/// Image: Image of dish
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("image")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue Image => this.Value<global::Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("image");

		///<summary>
		/// Ingredients: Ingredients of the dish
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("ingredients")]
		public global::System.Collections.Generic.IEnumerable<string> Ingredients => this.Value<global::System.Collections.Generic.IEnumerable<string>>("ingredients");

		///<summary>
		/// Rating: Rating from 1 tot 5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("rating")]
		public int Rating => this.Value<int>("rating");

		///<summary>
		/// Tags: Tags which match with the recipe
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("tags")]
		public global::System.Collections.Generic.IEnumerable<string> Tags => this.Value<global::System.Collections.Generic.IEnumerable<string>>("tags");

		///<summary>
		/// Total time: Total time to prepare the dish (in minutes)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("totalTime")]
		public int TotalTime => this.Value<int>("totalTime");

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.2")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}
}
