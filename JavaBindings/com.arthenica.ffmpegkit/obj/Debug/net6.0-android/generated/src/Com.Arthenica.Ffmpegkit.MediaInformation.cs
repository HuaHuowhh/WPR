using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/MediaInformation", DoNotGenerateAcw=true)]
	public partial class MediaInformation : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_BIT_RATE']"
		[Register ("KEY_BIT_RATE")]
		public const string KeyBitRate = (string) "bit_rate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_DURATION']"
		[Register ("KEY_DURATION")]
		public const string KeyDuration = (string) "duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_FILENAME']"
		[Register ("KEY_FILENAME")]
		public const string KeyFilename = (string) "filename";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_FORMAT']"
		[Register ("KEY_FORMAT")]
		public const string KeyFormat = (string) "format_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_FORMAT_LONG']"
		[Register ("KEY_FORMAT_LONG")]
		public const string KeyFormatLong = (string) "format_long_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_MEDIA_PROPERTIES']"
		[Register ("KEY_MEDIA_PROPERTIES")]
		public const string KeyMediaProperties = (string) "format";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_SIZE']"
		[Register ("KEY_SIZE")]
		public const string KeySize = (string) "size";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_START_TIME']"
		[Register ("KEY_START_TIME")]
		public const string KeyStartTime = (string) "start_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/field[@name='KEY_TAGS']"
		[Register ("KEY_TAGS")]
		public const string KeyTags = (string) "tags";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/MediaInformation", typeof (MediaInformation));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MediaInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/constructor[@name='MediaInformation' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.util.List&lt;com.arthenica.ffmpegkit.StreamInformation&gt;'] and parameter[3][@type='java.util.List&lt;com.arthenica.ffmpegkit.Chapter&gt;']]"
		[Register (".ctor", "(Lorg/json/JSONObject;Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe MediaInformation (global::Org.Json.JSONObject? jsonObject, global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.StreamInformation>? streams, global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Chapter>? chapters) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONObject;Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_streams = global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.StreamInformation>.ToLocalJniHandle (streams);
			IntPtr native_chapters = global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Chapter>.ToLocalJniHandle (chapters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				__args [1] = new JniArgumentValue (native_streams);
				__args [2] = new JniArgumentValue (native_chapters);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_streams);
				JNIEnv.DeleteLocalRef (native_chapters);
				global::System.GC.KeepAlive (jsonObject);
				global::System.GC.KeepAlive (streams);
				global::System.GC.KeepAlive (chapters);
			}
		}

		static Delegate? cb_getAllProperties;
#pragma warning disable 0169
		static Delegate GetGetAllPropertiesHandler ()
		{
			if (cb_getAllProperties == null)
				cb_getAllProperties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllProperties);
			return cb_getAllProperties;
		}

		static IntPtr n_GetAllProperties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AllProperties);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? AllProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getAllProperties' and count(parameter)=0]"
			[Register ("getAllProperties", "()Lorg/json/JSONObject;", "GetGetAllPropertiesHandler")]
			get {
				const string __id = "getAllProperties.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitrate);
			return cb_getBitrate;
		}

		static IntPtr n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Bitrate);
		}
#pragma warning restore 0169

		public virtual unsafe string? Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()Ljava/lang/String;", "GetGetBitrateHandler")]
			get {
				const string __id = "getBitrate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getChapters;
#pragma warning disable 0169
		static Delegate GetGetChaptersHandler ()
		{
			if (cb_getChapters == null)
				cb_getChapters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChapters);
			return cb_getChapters;
		}

		static IntPtr n_GetChapters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Chapter>.ToLocalJniHandle (__this.Chapters);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Chapter>? Chapters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getChapters' and count(parameter)=0]"
			[Register ("getChapters", "()Ljava/util/List;", "GetGetChaptersHandler")]
			get {
				const string __id = "getChapters.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Chapter>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Duration);
		}
#pragma warning restore 0169

		public virtual unsafe string? Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()Ljava/lang/String;", "GetGetDurationHandler")]
			get {
				const string __id = "getDuration.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getFilename;
#pragma warning disable 0169
		static Delegate GetGetFilenameHandler ()
		{
			if (cb_getFilename == null)
				cb_getFilename = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFilename);
			return cb_getFilename;
		}

		static IntPtr n_GetFilename (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Filename);
		}
#pragma warning restore 0169

		public virtual unsafe string? Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")]
			get {
				const string __id = "getFilename.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		public virtual unsafe string? Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLongFormat;
#pragma warning disable 0169
		static Delegate GetGetLongFormatHandler ()
		{
			if (cb_getLongFormat == null)
				cb_getLongFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLongFormat);
			return cb_getLongFormat;
		}

		static IntPtr n_GetLongFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LongFormat);
		}
#pragma warning restore 0169

		public virtual unsafe string? LongFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getLongFormat' and count(parameter)=0]"
			[Register ("getLongFormat", "()Ljava/lang/String;", "GetGetLongFormatHandler")]
			get {
				const string __id = "getLongFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getMediaProperties;
#pragma warning disable 0169
		static Delegate GetGetMediaPropertiesHandler ()
		{
			if (cb_getMediaProperties == null)
				cb_getMediaProperties = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMediaProperties);
			return cb_getMediaProperties;
		}

		static IntPtr n_GetMediaProperties (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.MediaProperties);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? MediaProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getMediaProperties' and count(parameter)=0]"
			[Register ("getMediaProperties", "()Lorg/json/JSONObject;", "GetGetMediaPropertiesHandler")]
			get {
				const string __id = "getMediaProperties.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Size);
		}
#pragma warning restore 0169

		public virtual unsafe string? Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Ljava/lang/String;", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StartTime);
		}
#pragma warning restore 0169

		public virtual unsafe string? StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/lang/String;", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStreams;
#pragma warning disable 0169
		static Delegate GetGetStreamsHandler ()
		{
			if (cb_getStreams == null)
				cb_getStreams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStreams);
			return cb_getStreams;
		}

		static IntPtr n_GetStreams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.StreamInformation>.ToLocalJniHandle (__this.Streams);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.StreamInformation>? Streams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getStreams' and count(parameter)=0]"
			[Register ("getStreams", "()Ljava/util/List;", "GetGetStreamsHandler")]
			get {
				const string __id = "getStreams.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.StreamInformation>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Lorg/json/JSONObject;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getNumberProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNumberProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getNumberProperty_Ljava_lang_String_ == null)
				cb_getNumberProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetNumberProperty_Ljava_lang_String_);
			return cb_getNumberProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetNumberProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumberProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getNumberProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNumberProperty", "(Ljava/lang/String;)Ljava/lang/Long;", "GetGetNumberProperty_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Long? GetNumberProperty (string? key)
		{
			const string __id = "getNumberProperty.(Ljava/lang/String;)Ljava/lang/Long;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate? cb_getProperties_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperties_Ljava_lang_String_Handler ()
		{
			if (cb_getProperties_Ljava_lang_String_ == null)
				cb_getProperties_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetProperties_Ljava_lang_String_);
			return cb_getProperties_Ljava_lang_String_;
		}

		static IntPtr n_GetProperties_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperties (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getProperties' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperties", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetProperties_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Json.JSONObject? GetProperties (string? key)
		{
			const string __id = "getProperties.(Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate? cb_getStringProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getStringProperty_Ljava_lang_String_ == null)
				cb_getStringProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStringProperty_Ljava_lang_String_);
			return cb_getStringProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetStringProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.MediaInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='MediaInformation']/method[@name='getStringProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetStringProperty_Ljava_lang_String_Handler")]
		public virtual unsafe string? GetStringProperty (string? key)
		{
			const string __id = "getStringProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
