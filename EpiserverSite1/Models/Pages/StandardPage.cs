using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "DefaultPage1", GUID = "53065327-3876-4417-9f90-91d6a5363dee", Description = "")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The page heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}