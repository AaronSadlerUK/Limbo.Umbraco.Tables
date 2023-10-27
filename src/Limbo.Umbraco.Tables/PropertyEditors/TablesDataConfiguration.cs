﻿using Newtonsoft.Json;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Tables.PropertyEditors;

/// <summary>
/// Represents the configuration for the tables editor.
/// </summary>
public class TablesDataConfiguration {

    /// <summary>
    /// Gets or sets whether the <strong>Use first row as header</strong> option is enabled in the property editor.
    /// </summary>
    [ConfigurationField("allowUseFirstRowAsHeader", "Allow 'Use first row as header' option", "boolean")]
    public bool AllowUseFirstRowAsHeader { get; set; } = true;

    /// <summary>
    /// Gets or sets whether the <strong>Use first column as header</strong> option is enabled in the property editor.
    /// </summary>
    [ConfigurationField("allowUseFirstColumnAsHeader", "Allow 'Use first column as header' option", "boolean")]
    public bool AllowUseFirstColumnAsHeader { get; set; } = true;

    /// <summary>
    /// Gets or sets whether the <strong>Use last row as footer</strong> option is enabled in the property editor.
    /// </summary>
    [ConfigurationField("allowUseLastRowAsFooter", "Allow 'Use last row as footer' option", "boolean")]
    public bool AllowUseLastRowAsFooter { get; set; }

    /// <summary>
    /// Gets or sets whether the label of the property editor should be hidden.
    /// </summary>
    [ConfigurationField("hideLabel", "Hide label", "boolean", Description = "Select whether the label and description of properties using this data type should be hidden.<br /><br />Hiding the label and description can be useful in some cases - eg. to give the video picker a bit more horizontal space.")]
    public bool HideLabel { get; set; }

    /// <summary>
    /// Configuration for the RTE.
    /// </summary>
    [ConfigurationField("rte", "Rich text editor", "views/propertyeditors/rte/rte.prevalues.html", Description = "Rich text editor configuration", HideLabel = true)]
    public object? Rte { get; set; }

}