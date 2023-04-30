using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/Chapter", DoNotGenerateAcw=true)]
	public partial class Chapter : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_END']"
		[Register ("KEY_END")]
		public const string KeyEnd = (string) "end";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_END_TIME']"
		[Register ("KEY_END_TIME")]
		public const string KeyEndTime = (string) "end_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_ID']"
		[Register ("KEY_ID")]
		public const string KeyId = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_START']"
		[Register ("KEY_START")]
		public const string KeyStart = (string) "start";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_START_TIME']"
		[Register ("KEY_START_TIME")]
		public const string KeyStartTime = (string) "start_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_TAGS']"
		[Register ("KEY_TAGS")]
		public const string KeyTags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/field[@name='KEY_TIME_BASE']"
		[Register ("KEY_TIME_BASE")]
		public const string KeyTimeBase = (string) "time_base";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/Chapter", typeof (Chapter));

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

		protected Chapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/constructor[@name='Chapter' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Chapter (global::Org.Json.JSONObject? jsonObject) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.AllProperties);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? AllProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getAllProperties' and count(parameter)=0]"
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

		static Delegate? cb_getEnd;
#pragma warning disable 0169
		static Delegate GetGetEndHandler ()
		{
			if (cb_getEnd == null)
				cb_getEnd = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnd);
			return cb_getEnd;
		}

		static IntPtr n_GetEnd (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.End);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? End {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()Ljava/lang/Long;", "GetGetEndHandler")]
			get {
				const string __id = "getEnd.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getEndTime;
#pragma warning disable 0169
		static Delegate GetGetEndTimeHandler ()
		{
			if (cb_getEndTime == null)
				cb_getEndTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEndTime);
			return cb_getEndTime;
		}

		static IntPtr n_GetEndTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.EndTime);
		}
#pragma warning restore 0169

		public virtual unsafe string? EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/lang/String;", "GetGetEndTimeHandler")]
			get {
				const string __id = "getEndTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/Long;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getStart;
#pragma warning disable 0169
		static Delegate GetGetStartHandler ()
		{
			if (cb_getStart == null)
				cb_getStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStart);
			return cb_getStart;
		}

		static IntPtr n_GetStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Start);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long? Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()Ljava/lang/Long;", "GetGetStartHandler")]
			get {
				const string __id = "getStart.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.StartTime);
		}
#pragma warning restore 0169

		public virtual unsafe string? StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getStartTime' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject? Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getTags' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.TimeBase);
		}
#pragma warning restore 0169

		public virtual unsafe string? TimeBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getTimeBase' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumberProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getNumberProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperties (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getProperties' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Chapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringProperty (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='Chapter']/method[@name='getStringProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
