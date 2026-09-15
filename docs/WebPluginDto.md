# DocSpace.API.SDK.Model.WebPluginDto
One web plugin available to the portal: its manifest, where to load it from, and the state the portal keeps.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The plugin's manifest name, which is what every other operation of this group addresses it by and what  makes it unique within the portal - an installation-wide plugin wins the name over a portal one. | 
**@Version** | **string** | The plugin's own version from its manifest. The portal does not compare it against anything; it is there  for a person to read. | 
**MinDocSpaceVersion** | **string** | The oldest portal version the plugin declares it works with. It is a claim from the manifest and is not  enforced, so a plugin can be loaded on an older portal and simply misbehave; compare it with the `version`  of `GET api/2.0/settings`. | [optional] 
**Description** | **string** | The plugin's description from its manifest, in the language the manifest was written in. The translations  of it are in `descriptionLocale`. | 
**License** | **string** | The licence the plugin is published under, as its manifest states it. Nothing checks it. | 
**Author** | **string** | Who wrote the plugin, as its manifest states it - not the portal member who uploaded it, who is  `createBy`. | 
**HomePage** | **string** | The plugin's own page, for a person to read more about it. It is empty when the manifest names none. | 
**PluginName** | **string** | The global the plugin registers itself under in the browser once its script has run, which is how a  client reaches it. It is distinct from `name`, the identifier the portal uses. | 
**Scopes** | **string** | Which parts of the interface the plugin hooks into, as one comma-separated string rather than a list. | 
**Image** | **string** | The plugin's icon exactly as its manifest declares it, which is normally a file name inside the plugin's  own package rather than an absolute address - resolve it against the directory `url` points into. | 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) | The portal member who uploaded the plugin. For a plugin that ships with the installation it is an empty  profile, since no member put it there. | 
**CreateOn** | **DateTime** | When the plugin was uploaded. It stays at its zero value for a plugin that ships with the installation. | 
**Enabled** | **bool** | Whether the portal loads the plugin. It is the state this portal stored, so an installation-wide plugin  can be on for one portal and off for another. | 
**System** | **bool** | Whether the plugin ships with the installation rather than having been uploaded here. A system plugin  cannot be deleted through `DELETE api/2.0/settings/webplugins/{name}`, only switched off. | 
**Url** | **string** | The address of the plugin's script, which a client loads to run it. It ends in a `hash` query taken from  `version`, so the address changes whenever the plugin is updated and an old one may be cached. | 
**CssUrl** | **string** | The absolute address of the plugin's stylesheet, empty for a plugin that ships none. | 
**Settings** | **string** | The settings string the portal keeps for the plugin, stored and returned verbatim - only the plugin knows  its shape. It is empty until `PUT api/2.0/settings/webplugins/{name}` saves one. | 
**NameLocale** | **Dictionary&lt;string, string&gt;** | The plugin's name translated, keyed by culture name. A culture that is missing falls back to `name`, and  the whole map is empty for a plugin that ships no translations. | [optional] 
**DescriptionLocale** | **Dictionary&lt;string, string&gt;** | The plugin's description translated, keyed the same way as `nameLocale` and falling back to  `description`. | [optional] 
**Runtime** | **string** | How the script at `url` is to be loaded - as an ES module or as a classic script. It is empty for a  plugin whose manifest does not say, which a client treats as a classic script. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

