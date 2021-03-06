﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace cloudnine.Models.Pages
{
    [ContentType(DisplayName = "Contacts", GUID = "28057d75-ffd9-4192-a86f-6d828cd99be6", Description = "")]
    public class Contacts : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Employes",
           Description = "",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        public virtual ContentArea Employes { get; set; }
    }
}