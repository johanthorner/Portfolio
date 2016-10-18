using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace cloudnine.Models.Blocks
{
    [ContentType(DisplayName = "CaseListBlock", GUID = "fdfdbd57-8dcb-49c5-b82e-3a8dd5fc7992", Description = "")]
    public class CaseList : BlockData
    {
        [CultureSpecific]
        [Display(
           Name = "Name",
           Description = "Name of Case",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
       Name = "Ingress",
       Description = "Short text about the case",
       GroupName = SystemTabNames.Content,
       Order = 2)]
        public virtual XhtmlString Ingress { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Case Refference",
          Description = "Place Case Reference here.",
          GroupName = SystemTabNames.Content,
          Order = 3)]
        public virtual ContentReference CaseRefference { get; set; }
    }
}