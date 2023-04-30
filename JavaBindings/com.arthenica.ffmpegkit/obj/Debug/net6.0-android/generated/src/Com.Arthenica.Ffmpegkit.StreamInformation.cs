using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/StreamInformation", DoNotGenerateAcw=true)]
	public partial class StreamInformation : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_AVERAGE_FRAME_RATE']"
		[Register ("KEY_AVERAGE_FRAME_RATE")]
		public const string KeyAverageFrameRate = (string) "avg_frame_rate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_BIT_RATE']"
		[Register ("KEY_BIT_RATE")]
		public const string KeyBitRate = (string) "bit_rate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_CHANNEL_LAYOUT']"
		[Register ("KEY_CHANNEL_LAYOUT")]
		public const string KeyChannelLayout = (string) "channel_layout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_CODEC']"
		[Register ("KEY_CODEC")]
		public const string KeyCodec = (string) "codec_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_CODEC_LONG']"
		[Register ("KEY_CODEC_LONG")]
		public const string KeyCodecLong = (string) "codec_long_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_CODEC_TIME_BASE']"
		[Register ("KEY_CODEC_TIME_BASE")]
		public const string KeyCodecTimeBase = (string) "codec_time_base";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_DISPLAY_ASPECT_RATIO']"
		[Register ("KEY_DISPLAY_ASPECT_RATIO")]
		public const string KeyDisplayAspectRatio = (string) "display_aspect_ratio";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_FORMAT']"
		[Register ("KEY_FORMAT")]
		public const string KeyFormat = (string) "pix_fmt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_HEIGHT']"
		[Register ("KEY_HEIGHT")]
		public const string KeyHeight = (string) "height";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_INDEX']"
		[Register ("KEY_INDEX")]
		public const string KeyIndex = (string) "index";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_REAL_FRAME_RATE']"
		[Register ("KEY_REAL_FRAME_RATE")]
		public const string KeyRealFrameRate = (string) "r_frame_rate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_SAMPLE_ASPECT_RATIO']"
		[Register ("KEY_SAMPLE_ASPECT_RATIO")]
		public const string KeySampleAspectRatio = (string) "sample_aspect_ratio";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_SAMPLE_FORMAT']"
		[Register ("KEY_SAMPLE_FORMAT")]
		public const string KeySampleFormat = (string) "sample_fmt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_SAMPLE_RATE']"
		[Register ("KEY_SAMPLE_RATE")]
		public const string KeySampleRate = (string) "sample_rate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_TAGS']"
		[Register ("KEY_TAGS")]
		public const string KeyTags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_TIME_BASE']"
		[Register ("KEY_TIME_BASE")]
		public const string KeyTimeBase = (string) "time_base";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_TYPE']"
		[Register ("KEY_TYPE")]
		public const string KeyType = (string) "codec_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/field[@name='KEY_WIDTH']"
		[Register ("KEY_WIDTH")]
		public const string KeyWidth = (string) "width";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/StreamInformation", typeof (StreamInformation));

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

		protected StreamInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/constructor[@name='StreamInformation' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe StreamInformation (global::Org.Json.JSONObject? jsonObject) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/json/JSONObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (jsonObject);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AllProperties);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? AllProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getAllProperties' and count(parameter)=0]"
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

		static Delegate? cb_getAverageFrameRate;
#pragma warning disable 0169
		static Delegate GetGetAverageFrameRateHandler ()
		{
			if (cb_getAverageFrameRate == null)
				cb_getAverageFrameRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAverageFrameRate);
			return cb_getAverageFrameRate;
		}

		static IntPtr n_GetAverageFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AverageFrameRate);
		}
#pragma warning restore 0169

		public virtual unsafe string? AverageFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getAverageFrameRate' and count(parameter)=0]"
			[Register ("getAverageFrameRate", "()Ljava/lang/String;", "GetGetAverageFrameRateHandler")]
			get {
				const string __id = "getAverageFrameRate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Bitrate);
		}
#pragma warning restore 0169

		public virtual unsafe string? Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getBitrate' and count(parameter)=0]"
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

		static Delegate? cb_getChannelLayout;
#pragma warning disable 0169
		static Delegate GetGetChannelLayoutHandler ()
		{
			if (cb_getChannelLayout == null)
				cb_getChannelLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetChannelLayout);
			return cb_getChannelLayout;
		}

		static IntPtr n_GetChannelLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ChannelLayout);
		}
#pragma warning restore 0169

		public virtual unsafe string? ChannelLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getChannelLayout' and count(parameter)=0]"
			[Register ("getChannelLayout", "()Ljava/lang/String;", "GetGetChannelLayoutHandler")]
			get {
				const string __id = "getChannelLayout.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCodec;
#pragma warning disable 0169
		static Delegate GetGetCodecHandler ()
		{
			if (cb_getCodec == null)
				cb_getCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodec);
			return cb_getCodec;
		}

		static IntPtr n_GetCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Codec);
		}
#pragma warning restore 0169

		public virtual unsafe string? Codec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getCodec' and count(parameter)=0]"
			[Register ("getCodec", "()Ljava/lang/String;", "GetGetCodecHandler")]
			get {
				const string __id = "getCodec.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCodecLong;
#pragma warning disable 0169
		static Delegate GetGetCodecLongHandler ()
		{
			if (cb_getCodecLong == null)
				cb_getCodecLong = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodecLong);
			return cb_getCodecLong;
		}

		static IntPtr n_GetCodecLong (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CodecLong);
		}
#pragma warning restore 0169

		public virtual unsafe string? CodecLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getCodecLong' and count(parameter)=0]"
			[Register ("getCodecLong", "()Ljava/lang/String;", "GetGetCodecLongHandler")]
			get {
				const string __id = "getCodecLong.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCodecTimeBase;
#pragma warning disable 0169
		static Delegate GetGetCodecTimeBaseHandler ()
		{
			if (cb_getCodecTimeBase == null)
				cb_getCodecTimeBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodecTimeBase);
			return cb_getCodecTimeBase;
		}

		static IntPtr n_GetCodecTimeBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CodecTimeBase);
		}
#pragma warning restore 0169

		public virtual unsafe string? CodecTimeBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getCodecTimeBase' and count(parameter)=0]"
			[Register ("getCodecTimeBase", "()Ljava/lang/String;", "GetGetCodecTimeBaseHandler")]
			get {
				const string __id = "getCodecTimeBase.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getDisplayAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetDisplayAspectRatioHandler ()
		{
			if (cb_getDisplayAspectRatio == null)
				cb_getDisplayAspectRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDisplayAspectRatio);
			return cb_getDisplayAspectRatio;
		}

		static IntPtr n_GetDisplayAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DisplayAspectRatio);
		}
#pragma warning restore 0169

		public virtual unsafe string? DisplayAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getDisplayAspectRatio' and count(parameter)=0]"
			[Register ("getDisplayAspectRatio", "()Ljava/lang/String;", "GetGetDisplayAspectRatioHandler")]
			get {
				const string __id = "getDisplayAspectRatio.()Ljava/lang/String;";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		public virtual unsafe string? Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getFormat' and count(parameter)=0]"
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

		static Delegate? cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()Ljava/lang/Long;", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIndex);
			return cb_getIndex;
		}

		static IntPtr n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Index);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()Ljava/lang/Long;", "GetGetIndexHandler")]
			get {
				const string __id = "getIndex.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getRealFrameRate;
#pragma warning disable 0169
		static Delegate GetGetRealFrameRateHandler ()
		{
			if (cb_getRealFrameRate == null)
				cb_getRealFrameRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRealFrameRate);
			return cb_getRealFrameRate;
		}

		static IntPtr n_GetRealFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.RealFrameRate);
		}
#pragma warning restore 0169

		public virtual unsafe string? RealFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getRealFrameRate' and count(parameter)=0]"
			[Register ("getRealFrameRate", "()Ljava/lang/String;", "GetGetRealFrameRateHandler")]
			get {
				const string __id = "getRealFrameRate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSampleAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetSampleAspectRatioHandler ()
		{
			if (cb_getSampleAspectRatio == null)
				cb_getSampleAspectRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleAspectRatio);
			return cb_getSampleAspectRatio;
		}

		static IntPtr n_GetSampleAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SampleAspectRatio);
		}
#pragma warning restore 0169

		public virtual unsafe string? SampleAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getSampleAspectRatio' and count(parameter)=0]"
			[Register ("getSampleAspectRatio", "()Ljava/lang/String;", "GetGetSampleAspectRatioHandler")]
			get {
				const string __id = "getSampleAspectRatio.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSampleFormat;
#pragma warning disable 0169
		static Delegate GetGetSampleFormatHandler ()
		{
			if (cb_getSampleFormat == null)
				cb_getSampleFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleFormat);
			return cb_getSampleFormat;
		}

		static IntPtr n_GetSampleFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SampleFormat);
		}
#pragma warning restore 0169

		public virtual unsafe string? SampleFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getSampleFormat' and count(parameter)=0]"
			[Register ("getSampleFormat", "()Ljava/lang/String;", "GetGetSampleFormatHandler")]
			get {
				const string __id = "getSampleFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSampleRate;
#pragma warning disable 0169
		static Delegate GetGetSampleRateHandler ()
		{
			if (cb_getSampleRate == null)
				cb_getSampleRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleRate);
			return cb_getSampleRate;
		}

		static IntPtr n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.SampleRate);
		}
#pragma warning restore 0169

		public virtual unsafe string? SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()Ljava/lang/String;", "GetGetSampleRateHandler")]
			get {
				const string __id = "getSampleRate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getTags' and count(parameter)=0]"
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

		static Delegate? cb_getTimeBase;
#pragma warning disable 0169
		static Delegate GetGetTimeBaseHandler ()
		{
			if (cb_getTimeBase == null)
				cb_getTimeBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeBase);
			return cb_getTimeBase;
		}

		static IntPtr n_GetTimeBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TimeBase);
		}
#pragma warning restore 0169

		public virtual unsafe string? TimeBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getTimeBase' and count(parameter)=0]"
			[Register ("getTimeBase", "()Ljava/lang/String;", "GetGetTimeBaseHandler")]
			get {
				const string __id = "getTimeBase.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe string? Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWidth);
			return cb_getWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Width);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()Ljava/lang/Long;", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumberProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getNumberProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperties (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getProperties' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.StreamInformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='StreamInformation']/method[@name='getStringProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
