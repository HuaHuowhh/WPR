using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']"
	[Register ("com/arthenica/smartexception/StackTraceElementSerializer", "", "Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker")]
	public partial interface IStackTraceElementSerializer : IJavaObject, IJavaPeerable {
		string? NativeMethodDefinition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']/method[@name='getNativeMethodDefinition' and count(parameter)=0]"
			[Register ("getNativeMethodDefinition", "()Ljava/lang/String;", "GetGetNativeMethodDefinitionHandler:Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker, com.arthenica.smartexception")]
			get; 
		}

		string? UnknownSourceDefinition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']/method[@name='getUnknownSourceDefinition' and count(parameter)=0]"
			[Register ("getUnknownSourceDefinition", "()Ljava/lang/String;", "GetGetUnknownSourceDefinitionHandler:Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker, com.arthenica.smartexception")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']/method[@name='getModuleName' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register ("getModuleName", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;", "GetGetModuleName_Ljava_lang_StackTraceElement_Handler:Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker, com.arthenica.smartexception")]
		string? GetModuleName (global::Java.Lang.StackTraceElement? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']/method[@name='getPackageInformation' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register ("getPackageInformation", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;", "GetGetPackageInformation_Ljava_lang_StackTraceElement_Handler:Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker, com.arthenica.smartexception")]
		string? GetPackageInformation (global::Java.Lang.StackTraceElement? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception']/interface[@name='StackTraceElementSerializer']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='java.lang.StackTraceElement'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("toString", "(Ljava/lang/StackTraceElement;ZZ)Ljava/lang/String;", "GetToString_Ljava_lang_StackTraceElement_ZZHandler:Com.Arthenica.Smartexception.IStackTraceElementSerializerInvoker, com.arthenica.smartexception")]
		string? ToString (global::Java.Lang.StackTraceElement? p0, bool p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/arthenica/smartexception/StackTraceElementSerializer", DoNotGenerateAcw=true)]
	internal partial class IStackTraceElementSerializerInvoker : global::Java.Lang.Object, IStackTraceElementSerializer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/StackTraceElementSerializer", typeof (IStackTraceElementSerializerInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IStackTraceElementSerializer? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStackTraceElementSerializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.smartexception.StackTraceElementSerializer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStackTraceElementSerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getNativeMethodDefinition;
#pragma warning disable 0169
		static Delegate GetGetNativeMethodDefinitionHandler ()
		{
			if (cb_getNativeMethodDefinition == null)
				cb_getNativeMethodDefinition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNativeMethodDefinition);
			return cb_getNativeMethodDefinition;
		}

		static IntPtr n_GetNativeMethodDefinition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NativeMethodDefinition);
		}
#pragma warning restore 0169

		IntPtr id_getNativeMethodDefinition;
		public unsafe string? NativeMethodDefinition {
			get {
				if (id_getNativeMethodDefinition == IntPtr.Zero)
					id_getNativeMethodDefinition = JNIEnv.GetMethodID (class_ref, "getNativeMethodDefinition", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeMethodDefinition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getUnknownSourceDefinition;
#pragma warning disable 0169
		static Delegate GetGetUnknownSourceDefinitionHandler ()
		{
			if (cb_getUnknownSourceDefinition == null)
				cb_getUnknownSourceDefinition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnknownSourceDefinition);
			return cb_getUnknownSourceDefinition;
		}

		static IntPtr n_GetUnknownSourceDefinition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.UnknownSourceDefinition);
		}
#pragma warning restore 0169

		IntPtr id_getUnknownSourceDefinition;
		public unsafe string? UnknownSourceDefinition {
			get {
				if (id_getUnknownSourceDefinition == IntPtr.Zero)
					id_getUnknownSourceDefinition = JNIEnv.GetMethodID (class_ref, "getUnknownSourceDefinition", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnknownSourceDefinition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_getModuleName_Ljava_lang_StackTraceElement_;
#pragma warning disable 0169
		static Delegate GetGetModuleName_Ljava_lang_StackTraceElement_Handler ()
		{
			if (cb_getModuleName_Ljava_lang_StackTraceElement_ == null)
				cb_getModuleName_Ljava_lang_StackTraceElement_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetModuleName_Ljava_lang_StackTraceElement_);
			return cb_getModuleName_Ljava_lang_StackTraceElement_;
		}

		static IntPtr n_GetModuleName_Ljava_lang_StackTraceElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetModuleName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getModuleName_Ljava_lang_StackTraceElement_;
		public unsafe string? GetModuleName (global::Java.Lang.StackTraceElement? p0)
		{
			if (id_getModuleName_Ljava_lang_StackTraceElement_ == IntPtr.Zero)
				id_getModuleName_Ljava_lang_StackTraceElement_ = JNIEnv.GetMethodID (class_ref, "getModuleName", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModuleName_Ljava_lang_StackTraceElement_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_getPackageInformation_Ljava_lang_StackTraceElement_;
#pragma warning disable 0169
		static Delegate GetGetPackageInformation_Ljava_lang_StackTraceElement_Handler ()
		{
			if (cb_getPackageInformation_Ljava_lang_StackTraceElement_ == null)
				cb_getPackageInformation_Ljava_lang_StackTraceElement_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPackageInformation_Ljava_lang_StackTraceElement_);
			return cb_getPackageInformation_Ljava_lang_StackTraceElement_;
		}

		static IntPtr n_GetPackageInformation_Ljava_lang_StackTraceElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageInformation (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPackageInformation_Ljava_lang_StackTraceElement_;
		public unsafe string? GetPackageInformation (global::Java.Lang.StackTraceElement? p0)
		{
			if (id_getPackageInformation_Ljava_lang_StackTraceElement_ == IntPtr.Zero)
				id_getPackageInformation_Ljava_lang_StackTraceElement_ = JNIEnv.GetMethodID (class_ref, "getPackageInformation", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageInformation_Ljava_lang_StackTraceElement_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_toString_Ljava_lang_StackTraceElement_ZZ;
#pragma warning disable 0169
		static Delegate GetToString_Ljava_lang_StackTraceElement_ZZHandler ()
		{
			if (cb_toString_Ljava_lang_StackTraceElement_ZZ == null)
				cb_toString_Ljava_lang_StackTraceElement_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_L) n_ToString_Ljava_lang_StackTraceElement_ZZ);
			return cb_toString_Ljava_lang_StackTraceElement_ZZ;
		}

		static IntPtr n_ToString_Ljava_lang_StackTraceElement_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.IStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToString (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toString_Ljava_lang_StackTraceElement_ZZ;
		public unsafe string? ToString (global::Java.Lang.StackTraceElement? p0, bool p1, bool p2)
		{
			if (id_toString_Ljava_lang_StackTraceElement_ZZ == IntPtr.Zero)
				id_toString_Ljava_lang_StackTraceElement_ZZ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/StackTraceElement;ZZ)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString_Ljava_lang_StackTraceElement_ZZ, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
