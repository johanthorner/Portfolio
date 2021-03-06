﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "1c0dfaf4-3cb7-4b77-966f-c1bb7c89ba59", Description = "")]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Title Page",
            Description = "Sidans titel",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Cases",
            Description = "Place Case presnetations here.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea CasesBlockArea { get; set; }
        
        [CultureSpecific]
        [Display(
            Name = "Customers",
            Description = "Customers",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea CustomersBlockArea { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Contact form",
         Description = "Place Contact form block here.",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        public virtual ContentArea ContactFormArea { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Case root",
         Description = "",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        public virtual ContentReference CaseRoot { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Blogg root",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 2)]
        public virtual ContentReference BloggRoot { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Jobbs root",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 2)]
        public virtual ContentReference JobbRoot { get; set; }

    }
}