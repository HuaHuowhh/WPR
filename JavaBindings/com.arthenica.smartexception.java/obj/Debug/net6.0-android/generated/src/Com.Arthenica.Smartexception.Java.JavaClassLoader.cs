using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Smartexception.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaClassLoader']"
	[global::Android.Runtime.Register ("com/arthenica/smartexception/java/JavaClassLoader", DoNotGenerateAcw=true)]
	public partial class JavaClassLoader : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/smartexception/java/JavaClassLoader", typeof (JavaClassLoader));

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

		protected JavaClassLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaClassLoader']/constructor[@name='JavaClassLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JavaClassLoader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate? cb_loadClass_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadClass_Ljava_lang_String_Handler ()
		{
			if (cb_loadClass_Ljava_lang_String_ == null)
				cb_loadClass_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_LoadClass_Ljava_lang_String_);
			return cb_loadClass_Ljava_lang_String_;
		}

		static IntPtr n_LoadClass_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_className)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Smartexception.Java.JavaClassLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var className = JNIEnv.GetString (native_className, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadClass (className));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.smartexception.java']/class[@name='JavaClassLoader']/method[@name='loadClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", "GetLoadClass_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Class? LoadClass (string? className)
		{
			const string __id = "loadClass.(Ljava/lang/String;)Ljava/lang/Class;";
			IntPtr native_className = JNIEnv.NewString ((string?)className);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_className);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

	}
}
