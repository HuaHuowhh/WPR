using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/AbstractSession", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSession : global::Java.Lang.Object, global::Com.Arthenica.Ffmpegkit.ISession {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/field[@name='arguments']"
		[Register ("arguments")]
		protected IList<string>? Arguments {
			get {
				const string __id = "arguments.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "arguments.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/field[@name='DEFAULT_TIMEOUT_FOR_ASYNCHRONOUS_MESSAGES_IN_TRANSMIT']"
		[Register ("DEFAULT_TIMEOUT_FOR_ASYNCHRONOUS_MESSAGES_IN_TRANSMIT")]
		public const int DefaultTimeoutForAsynchronousMessagesInTransmit = (int) 5000;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/field[@name='logsLock']"
		[Register ("logsLock")]
		protected global::Java.Lang.Object? LogsLock {
			get {
				const string __id = "logsLock.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "logsLock.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/field[@name='sessionIdGenerator']"
		[Register ("sessionIdGenerator")]
		protected static global::Java.Util.Concurrent.Atomic.AtomicLong? SessionIdGenerator {
			get {
				const string __id = "sessionIdGenerator.Ljava/util/concurrent/atomic/AtomicLong;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicLong> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/AbstractSession", typeof (AbstractSession));

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

		protected AbstractSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/constructor[@name='AbstractSession' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogRedirectionStrategy']]"
		[Register (".ctor", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V", "")]
		public unsafe AbstractSession (string[]? arguments, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? logRedirectionStrategy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [2] = new JniArgumentValue ((logRedirectionStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logRedirectionStrategy).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (logRedirectionStrategy);
			}
		}

		static Delegate? cb_getAllLogs;
#pragma warning disable 0169
		static Delegate GetGetAllLogsHandler ()
		{
			if (cb_getAllLogs == null)
				cb_getAllLogs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllLogs);
			return cb_getAllLogs;
		}

		static IntPtr n_GetAllLogs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.AllLogs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? AllLogs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getAllLogs' and count(parameter)=0]"
			[Register ("getAllLogs", "()Ljava/util/List;", "GetGetAllLogsHandler")]
			get {
				const string __id = "getAllLogs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getAllLogsAsString;
#pragma warning disable 0169
		static Delegate GetGetAllLogsAsStringHandler ()
		{
			if (cb_getAllLogsAsString == null)
				cb_getAllLogsAsString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAllLogsAsString);
			return cb_getAllLogsAsString;
		}

		static IntPtr n_GetAllLogsAsString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AllLogsAsString);
		}
#pragma warning restore 0169

		public virtual unsafe string? AllLogsAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getAllLogsAsString' and count(parameter)=0]"
			[Register ("getAllLogsAsString", "()Ljava/lang/String;", "GetGetAllLogsAsStringHandler")]
			get {
				const string __id = "getAllLogsAsString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCommand;
#pragma warning disable 0169
		static Delegate GetGetCommandHandler ()
		{
			if (cb_getCommand == null)
				cb_getCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommand);
			return cb_getCommand;
		}

		static IntPtr n_GetCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Command);
		}
#pragma warning restore 0169

		public virtual unsafe string? Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()Ljava/lang/String;", "GetGetCommandHandler")]
			get {
				const string __id = "getCommand.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getCreateTime;
#pragma warning disable 0169
		static Delegate GetGetCreateTimeHandler ()
		{
			if (cb_getCreateTime == null)
				cb_getCreateTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCreateTime);
			return cb_getCreateTime;
		}

		static IntPtr n_GetCreateTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CreateTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date? CreateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getCreateTime' and count(parameter)=0]"
			[Register ("getCreateTime", "()Ljava/util/Date;", "GetGetCreateTimeHandler")]
			get {
				const string __id = "getCreateTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Duration;
		}
#pragma warning restore 0169

		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				const string __id = "getDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.EndTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date? EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/util/Date;", "GetGetEndTimeHandler")]
			get {
				const string __id = "getEndTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getFailStackTrace;
#pragma warning disable 0169
		static Delegate GetGetFailStackTraceHandler ()
		{
			if (cb_getFailStackTrace == null)
				cb_getFailStackTrace = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFailStackTrace);
			return cb_getFailStackTrace;
		}

		static IntPtr n_GetFailStackTrace (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FailStackTrace);
		}
#pragma warning restore 0169

		public virtual unsafe string? FailStackTrace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getFailStackTrace' and count(parameter)=0]"
			[Register ("getFailStackTrace", "()Ljava/lang/String;", "GetGetFailStackTraceHandler")]
			get {
				const string __id = "getFailStackTrace.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getFuture;
#pragma warning disable 0169
		static Delegate GetGetFutureHandler ()
		{
			if (cb_getFuture == null)
				cb_getFuture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFuture);
			return cb_getFuture;
		}

		static IntPtr n_GetFuture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Future);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Concurrent.IFuture? Future {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getFuture' and count(parameter)=0]"
			[Register ("getFuture", "()Ljava/util/concurrent/Future;", "GetGetFutureHandler")]
			get {
				const string __id = "getFuture.()Ljava/util/concurrent/Future;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLogCallback;
#pragma warning disable 0169
		static Delegate GetGetLogCallbackHandler ()
		{
			if (cb_getLogCallback == null)
				cb_getLogCallback = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogCallback);
			return cb_getLogCallback;
		}

		static IntPtr n_GetLogCallback (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LogCallback);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.ILogCallback? LogCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getLogCallback' and count(parameter)=0]"
			[Register ("getLogCallback", "()Lcom/arthenica/ffmpegkit/LogCallback;", "GetGetLogCallbackHandler")]
			get {
				const string __id = "getLogCallback.()Lcom/arthenica/ffmpegkit/LogCallback;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ILogCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLogRedirectionStrategy;
#pragma warning disable 0169
		static Delegate GetGetLogRedirectionStrategyHandler ()
		{
			if (cb_getLogRedirectionStrategy == null)
				cb_getLogRedirectionStrategy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogRedirectionStrategy);
			return cb_getLogRedirectionStrategy;
		}

		static IntPtr n_GetLogRedirectionStrategy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LogRedirectionStrategy);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? LogRedirectionStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getLogRedirectionStrategy' and count(parameter)=0]"
			[Register ("getLogRedirectionStrategy", "()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;", "GetGetLogRedirectionStrategyHandler")]
			get {
				const string __id = "getLogRedirectionStrategy.()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLogs;
#pragma warning disable 0169
		static Delegate GetGetLogsHandler ()
		{
			if (cb_getLogs == null)
				cb_getLogs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogs);
			return cb_getLogs;
		}

		static IntPtr n_GetLogs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.Logs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? Logs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getLogs' and count(parameter)=0]"
			[Register ("getLogs", "()Ljava/util/List;", "GetGetLogsHandler")]
			get {
				const string __id = "getLogs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getLogsAsString;
#pragma warning disable 0169
		static Delegate GetGetLogsAsStringHandler ()
		{
			if (cb_getLogsAsString == null)
				cb_getLogsAsString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLogsAsString);
			return cb_getLogsAsString;
		}

		static IntPtr n_GetLogsAsString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LogsAsString);
		}
#pragma warning restore 0169

		public virtual unsafe string? LogsAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getLogsAsString' and count(parameter)=0]"
			[Register ("getLogsAsString", "()Ljava/lang/String;", "GetGetLogsAsStringHandler")]
			get {
				const string __id = "getLogsAsString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getOutput;
#pragma warning disable 0169
		static Delegate GetGetOutputHandler ()
		{
			if (cb_getOutput == null)
				cb_getOutput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutput);
			return cb_getOutput;
		}

		static IntPtr n_GetOutput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Output);
		}
#pragma warning restore 0169

		public virtual unsafe string? Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/lang/String;", "GetGetOutputHandler")]
			get {
				const string __id = "getOutput.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getReturnCode;
#pragma warning disable 0169
		static Delegate GetGetReturnCodeHandler ()
		{
			if (cb_getReturnCode == null)
				cb_getReturnCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReturnCode);
			return cb_getReturnCode;
		}

		static IntPtr n_GetReturnCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ReturnCode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.ReturnCode? ReturnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getReturnCode' and count(parameter)=0]"
			[Register ("getReturnCode", "()Lcom/arthenica/ffmpegkit/ReturnCode;", "GetGetReturnCodeHandler")]
			get {
				const string __id = "getReturnCode.()Lcom/arthenica/ffmpegkit/ReturnCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSessionId);
			return cb_getSessionId;
		}

		static long n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SessionId;
		}
#pragma warning restore 0169

		public virtual unsafe long SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()J", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date? StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/util/Date;", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Arthenica.Ffmpegkit.SessionState? State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/arthenica/ffmpegkit/SessionState;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lcom/arthenica/ffmpegkit/SessionState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_addLog_Lcom_arthenica_ffmpegkit_Log_;
#pragma warning disable 0169
		static Delegate GetAddLog_Lcom_arthenica_ffmpegkit_Log_Handler ()
		{
			if (cb_addLog_Lcom_arthenica_ffmpegkit_Log_ == null)
				cb_addLog_Lcom_arthenica_ffmpegkit_Log_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddLog_Lcom_arthenica_ffmpegkit_Log_);
			return cb_addLog_Lcom_arthenica_ffmpegkit_Log_;
		}

		static void n_AddLog_Lcom_arthenica_ffmpegkit_Log_ (IntPtr jnienv, IntPtr native__this, IntPtr native_log)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var log = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Log> (native_log, JniHandleOwnership.DoNotTransfer);
			__this.AddLog (log);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='addLog' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Log']]"
		[Register ("addLog", "(Lcom/arthenica/ffmpegkit/Log;)V", "GetAddLog_Lcom_arthenica_ffmpegkit_Log_Handler")]
		public virtual unsafe void AddLog (global::Com.Arthenica.Ffmpegkit.Log? log)
		{
			const string __id = "addLog.(Lcom/arthenica/ffmpegkit/Log;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((log == null) ? IntPtr.Zero : ((global::Java.Lang.Object) log).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (log);
			}
		}

		static Delegate? cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_getAllLogs_I;
#pragma warning disable 0169
		static Delegate GetGetAllLogs_IHandler ()
		{
			if (cb_getAllLogs_I == null)
				cb_getAllLogs_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetAllLogs_I);
			return cb_getAllLogs_I;
		}

		static IntPtr n_GetAllLogs_I (IntPtr jnienv, IntPtr native__this, int waitTimeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.GetAllLogs (waitTimeout));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getAllLogs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAllLogs", "(I)Ljava/util/List;", "GetGetAllLogs_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? GetAllLogs (int waitTimeout)
		{
			const string __id = "getAllLogs.(I)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (waitTimeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_getAllLogsAsString_I;
#pragma warning disable 0169
		static Delegate GetGetAllLogsAsString_IHandler ()
		{
			if (cb_getAllLogsAsString_I == null)
				cb_getAllLogsAsString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetAllLogsAsString_I);
			return cb_getAllLogsAsString_I;
		}

		static IntPtr n_GetAllLogsAsString_I (IntPtr jnienv, IntPtr native__this, int waitTimeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GetAllLogsAsString (waitTimeout));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getAllLogsAsString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAllLogsAsString", "(I)Ljava/lang/String;", "GetGetAllLogsAsString_IHandler")]
		public virtual unsafe string? GetAllLogsAsString (int waitTimeout)
		{
			const string __id = "getAllLogsAsString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (waitTimeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate? cb_getArguments;
#pragma warning disable 0169
		static Delegate GetGetArgumentsHandler ()
		{
			if (cb_getArguments == null)
				cb_getArguments = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetArguments);
			return cb_getArguments;
		}

		static IntPtr n_GetArguments (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetArguments ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='getArguments' and count(parameter)=0]"
		[Register ("getArguments", "()[Ljava/lang/String;", "GetGetArgumentsHandler")]
		public virtual unsafe string[]? GetArguments ()
		{
			const string __id = "getArguments.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate? cb_thereAreAsynchronousMessagesInTransmit;
#pragma warning disable 0169
		static Delegate GetThereAreAsynchronousMessagesInTransmitHandler ()
		{
			if (cb_thereAreAsynchronousMessagesInTransmit == null)
				cb_thereAreAsynchronousMessagesInTransmit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ThereAreAsynchronousMessagesInTransmit);
			return cb_thereAreAsynchronousMessagesInTransmit;
		}

		static bool n_ThereAreAsynchronousMessagesInTransmit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ThereAreAsynchronousMessagesInTransmit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='thereAreAsynchronousMessagesInTransmit' and count(parameter)=0]"
		[Register ("thereAreAsynchronousMessagesInTransmit", "()Z", "GetThereAreAsynchronousMessagesInTransmitHandler")]
		public virtual unsafe bool ThereAreAsynchronousMessagesInTransmit ()
		{
			const string __id = "thereAreAsynchronousMessagesInTransmit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_waitForAsynchronousMessagesInTransmit_I;
#pragma warning disable 0169
		static Delegate GetWaitForAsynchronousMessagesInTransmit_IHandler ()
		{
			if (cb_waitForAsynchronousMessagesInTransmit_I == null)
				cb_waitForAsynchronousMessagesInTransmit_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_WaitForAsynchronousMessagesInTransmit_I);
			return cb_waitForAsynchronousMessagesInTransmit_I;
		}

		static void n_WaitForAsynchronousMessagesInTransmit_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.WaitForAsynchronousMessagesInTransmit (timeout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='waitForAsynchronousMessagesInTransmit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("waitForAsynchronousMessagesInTransmit", "(I)V", "GetWaitForAsynchronousMessagesInTransmit_IHandler")]
		protected virtual unsafe void WaitForAsynchronousMessagesInTransmit (int timeout)
		{
			const string __id = "waitForAsynchronousMessagesInTransmit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_isFFmpeg;
#pragma warning disable 0169
		static Delegate GetIsFFmpegHandler ()
		{
			if (cb_isFFmpeg == null)
				cb_isFFmpeg = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFmpeg);
			return cb_isFFmpeg;
		}

		static bool n_IsFFmpeg (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFmpeg;
		}
#pragma warning restore 0169

		public abstract bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isFFmpeg' and count(parameter)=0]"
			[Register ("isFFmpeg", "()Z", "GetIsFFmpegHandler")]
			get; 
		}

		static Delegate? cb_isFFprobe;
#pragma warning disable 0169
		static Delegate GetIsFFprobeHandler ()
		{
			if (cb_isFFprobe == null)
				cb_isFFprobe = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFFprobe);
			return cb_isFFprobe;
		}

		static bool n_IsFFprobe (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFprobe;
		}
#pragma warning restore 0169

		public abstract bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isFFprobe' and count(parameter)=0]"
			[Register ("isFFprobe", "()Z", "GetIsFFprobeHandler")]
			get; 
		}

		static Delegate? cb_isMediaInformation;
#pragma warning disable 0169
		static Delegate GetIsMediaInformationHandler ()
		{
			if (cb_isMediaInformation == null)
				cb_isMediaInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMediaInformation);
			return cb_isMediaInformation;
		}

		static bool n_IsMediaInformation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.AbstractSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMediaInformation;
		}
#pragma warning restore 0169

		public abstract bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isMediaInformation' and count(parameter)=0]"
			[Register ("isMediaInformation", "()Z", "GetIsMediaInformationHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/AbstractSession", DoNotGenerateAcw=true)]
	internal partial class AbstractSessionInvoker : AbstractSession {
		public AbstractSessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/AbstractSession", typeof (AbstractSessionInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isFFmpeg' and count(parameter)=0]"
			[Register ("isFFmpeg", "()Z", "GetIsFFmpegHandler")]
			get {
				const string __id = "isFFmpeg.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isFFprobe' and count(parameter)=0]"
			[Register ("isFFprobe", "()Z", "GetIsFFprobeHandler")]
			get {
				const string __id = "isFFprobe.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='AbstractSession']/method[@name='isMediaInformation' and count(parameter)=0]"
			[Register ("isMediaInformation", "()Z", "GetIsMediaInformationHandler")]
			get {
				const string __id = "isMediaInformation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
