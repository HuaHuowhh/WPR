using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/java/JavaStackTraceElementSerializer", DoNotGenerateAcw=true)]
	public partial class JavaStackTraceElementSerializer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/java/JavaStackTraceElementSerializer", typeof (JavaStackTraceElementSerializer));

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

		protected JavaStackTraceElementSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/constructor[@name='JavaStackTraceElementSerializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JavaStackTraceElementSerializer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.NativeMethodDefinition);
		}
#pragma warning restore 0169

		public virtual unsafe string? NativeMethodDefinition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/method[@name='getNativeMethodDefinition' and count(parameter)=0]"
			[Register ("getNativeMethodDefinition", "()Ljava/lang/String;", "GetGetNativeMethodDefinitionHandler")]
			get {
				const string __id = "getNativeMethodDefinition.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.UnknownSourceDefinition);
		}
#pragma warning restore 0169

		public virtual unsafe string? UnknownSourceDefinition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/method[@name='getUnknownSourceDefinition' and count(parameter)=0]"
			[Register ("getUnknownSourceDefinition", "()Ljava/lang/String;", "GetGetUnknownSourceDefinitionHandler")]
			get {
				const string __id = "getUnknownSourceDefinition.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static IntPtr n_GetModuleName_Ljava_lang_StackTraceElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stackTraceElement)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var stackTraceElement = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_stackTraceElement, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetModuleName (stackTraceElement));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/method[@name='getModuleName' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register ("getModuleName", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;", "GetGetModuleName_Ljava_lang_StackTraceElement_Handler")]
		public virtual unsafe string? GetModuleName (global::Java.Lang.StackTraceElement? stackTraceElement)
		{
			const string __id = "getModuleName.(Ljava/lang/StackTraceElement;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stackTraceElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stackTraceElement).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (stackTraceElement);
			}
		}

		static Delegate? cb_getPackageInformation_Ljava_lang_StackTraceElement_;
#pragma warning disable 0169
		static Delegate GetGetPackageInformation_Ljava_lang_StackTraceElement_Handler ()
		{
			if (cb_getPackageInformation_Ljava_lang_StackTraceElement_ == null)
				cb_getPackageInformation_Ljava_lang_StackTraceElement_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPackageInformation_Ljava_lang_StackTraceElement_);
			return cb_getPackageInformation_Ljava_lang_StackTraceElement_;
		}

		static IntPtr n_GetPackageInformation_Ljava_lang_StackTraceElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stackTraceElement)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var stackTraceElement = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_stackTraceElement, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageInformation (stackTraceElement));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/method[@name='getPackageInformation' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
		[Register ("getPackageInformation", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;", "GetGetPackageInformation_Ljava_lang_StackTraceElement_Handler")]
		public virtual unsafe string? GetPackageInformation (global::Java.Lang.StackTraceElement? stackTraceElement)
		{
			const string __id = "getPackageInformation.(Ljava/lang/StackTraceElement;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stackTraceElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stackTraceElement).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (stackTraceElement);
			}
		}

		static Delegate? cb_toString_Ljava_lang_StackTraceElement_ZZ;
#pragma warning disable 0169
		static Delegate GetToString_Ljava_lang_StackTraceElement_ZZHandler ()
		{
			if (cb_toString_Ljava_lang_StackTraceElement_ZZ == null)
				cb_toString_Ljava_lang_StackTraceElement_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_L) n_ToString_Ljava_lang_StackTraceElement_ZZ);
			return cb_toString_Ljava_lang_StackTraceElement_ZZ;
		}

		static IntPtr n_ToString_Ljava_lang_StackTraceElement_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_stackTraceElement, bool printModuleName, bool printPackageInformation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaStackTraceElementSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var stackTraceElement = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_stackTraceElement, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToString (stackTraceElement, printModuleName, printPackageInformation));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaStackTraceElementSerializer']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='java.lang.StackTraceElement'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("toString", "(Ljava/lang/StackTraceElement;ZZ)Ljava/lang/String;", "GetToString_Ljava_lang_StackTraceElement_ZZHandler")]
		public virtual unsafe string? ToString (global::Java.Lang.StackTraceElement? stackTraceElement, bool printModuleName, bool printPackageInformation)
		{
			const string __id = "toString.(Ljava/lang/StackTraceElement;ZZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((stackTraceElement == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stackTraceElement).Handle);
				__args [1] = new JniArgumentValue (printModuleName);
				__args [2] = new JniArgumentValue (printPackageInformation);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (stackTraceElement);
			}
		}

	}
}
