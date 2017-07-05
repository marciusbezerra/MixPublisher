using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixPublisher
{
    class Class1
    {
    }


    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Project_Data
    {
        /// <remarks/>
        public Project_DataProject_Settings Project_Settings { get; set; }

        /// <remarks/>
        public string AutoSaveFile { get; set; }

        /// <remarks/>
        public string ProjectID { get; set; }

        /// <remarks/>
        public byte PowerPointProject { get; set; }

        /// <remarks/>
        public object PowerPointFilename { get; set; }

        /// <remarks/>
        public object Project_Notes { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Project_MetaData_Object", IsNullable = false)]
        public Project_DataProject_MetaData_Object[] Project_MetaData { get; set; }

        /// <remarks/>
        public Project_DataCSMLData CSMLData { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal Version { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataProject_Settings
    {
        /// <remarks/>
        public object ProfileName { get; set; }

        /// <remarks/>
        public ushort ProjectWidth { get; set; }

        /// <remarks/>
        public ushort ProjectHeight { get; set; }

        /// <remarks/>
        public byte IsCustomProject { get; set; }

        /// <remarks/>
        public byte SavedProjectSettings { get; set; }

        /// <remarks/>
        public sbyte LastFlashTemplate { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataProject_MetaData_Object
    {
        /// <remarks/>
        public byte FieldArrayKey { get; set; }

        /// <remarks/>
        public string Value { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProject GoProject { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProject
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProject Project { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal version { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProject
    {
        /// <remarks/>
        public object Author { get; set; }

        /// <remarks/>
        public object Comment { get; set; }

        /// <remarks/>
        public object System { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectSourceBin SourceBin { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimeline Timeline { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string editRate { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal version { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectSourceBin
    {
        /// <remarks/>
        [XmlElementAttribute("Source")]
        public Project_DataCSMLDataGoProjectProjectSourceBinSource[] Source { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectSourceBinSource
    {
        /// <remarks/>
        [XmlElementAttribute("SourceTrack")]
        public Project_DataCSMLDataGoProjectProjectSourceBinSourceSourceTrack[] SourceTrack { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string src { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string lastMod { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string rect { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectSourceBinSourceSourceTrack
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string range { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte type { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string editRate { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string trackRect { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string sampleRate { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bitDepth { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte numChannels { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string filename { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string metaData { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimeline
    {
        /// <remarks/>
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineAttribute[] Attributes { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixer GenericMixer { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineCaptionAttributes CaptionAttributes { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineParameters Parameters { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineAttribute
    {
        /// <remarks/>
        [XmlAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixer
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerMetaData MetaData { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("GenericTrack", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrack[] Tracks { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerMetaData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerMetaDataEntry entry { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerMetaDataEntry
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string val { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrack
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackAttributes Attributes { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("entry", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackEntry[] MetaData { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMedias Medias { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackAttributes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackAttributesAttribute Attribute { get; set;
        }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackAttributesAttribute
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackEntry
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string val { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMedias
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCallout Callout { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFile AMFile { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMedia UnifiedMedia {
            get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCallout
    {
        /// <remarks/>
        [XmlArrayItemAttribute("VectorParam", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutVectorParam[] Transformer
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParameters Parameters {
            get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffects Effects { get; set;
        }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributes Attributes {
            get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutMetaData MetaData { get; set;
        }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeMods LeftEdgeMods
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeMods RightEdgeMods
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraData ExtraData {
            get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte start { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte duration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string scalar { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaStart { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaDuration { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutVectorParam
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutVectorParamInterpolatingParam[] InterpolatingParam
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutVectorParamInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public double value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParameters
    {
        /// <remarks/>
        [XmlElementAttribute("VectorParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersVectorParam[] VectorParam
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersInterpolatingParam InterpolatingParam
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersVectorParam
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersVectorParamInterpolatingParam[] InterpolatingParam
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersVectorParamInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffects
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffect GenericEffect
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffect
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParameters Parameters
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParameters
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam", typeof(Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersInterpolatingParam))]
        [XmlElementAttribute("Parameter", typeof(Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameter))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameter
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameterKeyframes Keyframes
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameterKeyframes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameterKeyframesKeyframe Keyframe
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutEffectsGenericEffectParametersParameterKeyframesKeyframe
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttribute Attribute
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttribute
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNode VectorNode
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNode
    {
        /// <remarks/>
        [XmlArrayItemAttribute("InterpolatingParam", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeInterpolatingParam[] DoubleParameters
        { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Parameter", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameter[] StringParameters
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string kind { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameter
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameterKeyframes Keyframes
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameterKeyframes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameterKeyframesKeyframe Keyframe
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutAttributesAttributeVectorNodeParameterKeyframesKeyframe
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutMetaData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutMetaDataEntry entry {
            get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutMetaDataEntry
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string val { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeMods
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeModsEdgeMod EdgeMod
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string length { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string groupName { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeModsEdgeMod
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeModsEdgeModFadeInFunc FadeInFunc
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte parameter { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutLeftEdgeModsEdgeModFadeInFunc
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeMods
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeModsEdgeMod EdgeMod
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string length { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string groupName { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeModsEdgeMod
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeModsEdgeModFadeOutFunc FadeOutFunc
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte parameter { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutRightEdgeModsEdgeModFadeOutFunc
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntry Entry {
            get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntry
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBin ZoomPanBin
        { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string key { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBin
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBinZoomPanKeyframes ZoomPanKeyframes
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBinZoomPanKeyframes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBinZoomPanKeyframesZoomPanKeyframe ZoomPanKeyframe
        { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasCalloutExtraDataEntryZoomPanBinZoomPanKeyframesZoomPanKeyframe
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string timeRangeEnd { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string timeRangeDuration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interpolaterName { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFile
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParameters Parameters {
            get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileAttribute[] Attributes {
            get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileMetaData MetaData { get; set;
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte start { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint duration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string scalar { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaStart { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaDuration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte trackNumber { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte src { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string channelNumber { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParameters
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParametersInterpolatingParam InterpolatingParam
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParametersParameter Parameter
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileParametersParameter
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileAttribute
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileMetaData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileMetaDataEntry entry {
            get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasAMFileMetaDataEntry
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string val { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMedia
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFile AMFile {
            get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFile VMFile {
            get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaMetaData MetaData {
            get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFile
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParameters Parameters
        { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileAttribute[] Attributes
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte start { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort duration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string scalar { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaStart { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaDuration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte trackNumber { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte src { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string channelNumber { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParameters
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParametersInterpolatingParam InterpolatingParam
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParametersParameter Parameter
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileParametersParameter
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaAMFileAttribute
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFile
    {
        /// <remarks/>
        [XmlArrayItemAttribute("VectorParam", IsNullable = false)]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileVectorParam[] Transformer
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParameters Parameters
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileAttributes Attributes
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraData ExtraData
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte start { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort duration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string scalar { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaStart { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string mediaDuration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte trackNumber { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte src { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileVectorParam
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileVectorParamInterpolatingParam[] InterpolatingParam
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileVectorParamInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interpolater { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParameters
    {
        /// <remarks/>
        [XmlElementAttribute("VectorParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersVectorParam[] VectorParam
        { get; set; }

        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersInterpolatingParam InterpolatingParam
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersVectorParam
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersVectorParamInterpolatingParam[] InterpolatingParam
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersVectorParamInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interpolater { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interpolater { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileAttributes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileAttributesAttribute Attribute
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileAttributesAttribute
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntry Entry
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntry
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBin ZoomPanBin
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBin
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBinZoomPanKeyframes ZoomPanKeyframes
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBinZoomPanKeyframes
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBinZoomPanKeyframesZoomPanKeyframe ZoomPanKeyframe
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaVMFileExtraDataEntryZoomPanBinZoomPanKeyframesZoomPanKeyframe
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string timeRangeEnd { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string timeRangeDuration { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interpolaterName { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaMetaData
    {
        /// <remarks/>
        public Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaMetaDataEntry entry
        { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineGenericMixerGenericTrackMediasUnifiedMediaMetaDataEntry
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string key { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string val { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineCaptionAttributes
    {
        /// <remarks/>
        [XmlElementAttribute("Attribute")]
        public Project_DataCSMLDataGoProjectProjectTimelineCaptionAttributesAttribute[] Attribute { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineCaptionAttributesAttribute
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineParameters
    {
        /// <remarks/>
        [XmlElementAttribute("VectorParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineParametersVectorParam[] VectorParam { get; set; }

        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineParametersInterpolatingParam[] InterpolatingParam { get; set;
        }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineParametersVectorParam
    {
        /// <remarks/>
        [XmlElementAttribute("InterpolatingParam")]
        public Project_DataCSMLDataGoProjectProjectTimelineParametersVectorParamInterpolatingParam[] InterpolatingParam
        { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineParametersVectorParamInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class Project_DataCSMLDataGoProjectProjectTimelineParametersInterpolatingParam
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string interp { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string time { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string leadInLength { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name { get; set; }
    }


}
