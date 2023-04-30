using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']"
	[Register ("com/arthenica/ffmpegkit/Session", "", "Com.Arthenica.Ffmpegkit.ISessionInvoker")]
	public partial interface ISession : IJavaObject, IJavaPeerable {
		global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? AllLogs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getAllLogs' and count(parameter)=0]"
			[Register ("getAllLogs", "()Ljava/util/List;", "GetGetAllLogsHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		string? AllLogsAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getAllLogsAsString' and count(parameter)=0]"
			[Register ("getAllLogsAsString", "()Ljava/lang/String;", "GetGetAllLogsAsStringHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		string? Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()Ljava/lang/String;", "GetGetCommandHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Java.Util.Date? CreateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getCreateTime' and count(parameter)=0]"
			[Register ("getCreateTime", "()Ljava/util/Date;", "GetGetCreateTimeHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Java.Util.Date? EndTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getEndTime' and count(parameter)=0]"
			[Register ("getEndTime", "()Ljava/util/Date;", "GetGetEndTimeHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		string? FailStackTrace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getFailStackTrace' and count(parameter)=0]"
			[Register ("getFailStackTrace", "()Ljava/lang/String;", "GetGetFailStackTraceHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Java.Util.Concurrent.IFuture? Future {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getFuture' and count(parameter)=0]"
			[Register ("getFuture", "()Ljava/util/concurrent/Future;", "GetGetFutureHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		bool IsFFmpeg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='isFFmpeg' and count(parameter)=0]"
			[Register ("isFFmpeg", "()Z", "GetIsFFmpegHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		bool IsFFprobe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='isFFprobe' and count(parameter)=0]"
			[Register ("isFFprobe", "()Z", "GetIsFFprobeHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		bool IsMediaInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='isMediaInformation' and count(parameter)=0]"
			[Register ("isMediaInformation", "()Z", "GetIsMediaInformationHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Com.Arthenica.Ffmpegkit.ILogCallback? LogCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getLogCallback' and count(parameter)=0]"
			[Register ("getLogCallback", "()Lcom/arthenica/ffmpegkit/LogCallback;", "GetGetLogCallbackHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? LogRedirectionStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getLogRedirectionStrategy' and count(parameter)=0]"
			[Register ("getLogRedirectionStrategy", "()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;", "GetGetLogRedirectionStrategyHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? Logs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getLogs' and count(parameter)=0]"
			[Register ("getLogs", "()Ljava/util/List;", "GetGetLogsHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		string? LogsAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getLogsAsString' and count(parameter)=0]"
			[Register ("getLogsAsString", "()Ljava/lang/String;", "GetGetLogsAsStringHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		string? Output {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getOutput' and count(parameter)=0]"
			[Register ("getOutput", "()Ljava/lang/String;", "GetGetOutputHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Com.Arthenica.Ffmpegkit.ReturnCode? ReturnCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getReturnCode' and count(parameter)=0]"
			[Register ("getReturnCode", "()Lcom/arthenica/ffmpegkit/ReturnCode;", "GetGetReturnCodeHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		long SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()J", "GetGetSessionIdHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Java.Util.Date? StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/util/Date;", "GetGetStartTimeHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		global::Com.Arthenica.Ffmpegkit.SessionState? State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/arthenica/ffmpegkit/SessionState;", "GetGetStateHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='addLog' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Log']]"
		[Register ("addLog", "(Lcom/arthenica/ffmpegkit/Log;)V", "GetAddLog_Lcom_arthenica_ffmpegkit_Log_Handler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		void AddLog (global::Com.Arthenica.Ffmpegkit.Log? log);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getAllLogs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAllLogs", "(I)Ljava/util/List;", "GetGetAllLogs_IHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? GetAllLogs (int waitTimeout);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getAllLogsAsString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAllLogsAsString", "(I)Ljava/lang/String;", "GetGetAllLogsAsString_IHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		string? GetAllLogsAsString (int waitTimeout);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='getArguments' and count(parameter)=0]"
		[Register ("getArguments", "()[Ljava/lang/String;", "GetGetArgumentsHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		string[]? GetArguments ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/interface[@name='Session']/method[@name='thereAreAsynchronousMessagesInTransmit' and count(parameter)=0]"
		[Register ("thereAreAsynchronousMessagesInTransmit", "()Z", "GetThereAreAsynchronousMessagesInTransmitHandler:Com.Arthenica.Ffmpegkit.ISessionInvoker, com.arthenica.ffmpegkit")]
		bool ThereAreAsynchronousMessagesInTransmit ();

	}

	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/Session", DoNotGenerateAcw=true)]
	internal partial class ISessionInvoker : global::Java.Lang.Object, ISession {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/Session", typeof (ISessionInvoker));

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

		public static ISession? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISession> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.arthenica.ffmpegkit.Session'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.AllLogs);
		}
#pragma warning restore 0169

		IntPtr id_getAllLogs;
		public unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? AllLogs {
			get {
				if (id_getAllLogs == IntPtr.Zero)
					id_getAllLogs = JNIEnv.GetMethodID (class_ref, "getAllLogs", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllLogs), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.AllLogsAsString);
		}
#pragma warning restore 0169

		IntPtr id_getAllLogsAsString;
		public unsafe string? AllLogsAsString {
			get {
				if (id_getAllLogsAsString == IntPtr.Zero)
					id_getAllLogsAsString = JNIEnv.GetMethodID (class_ref, "getAllLogsAsString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllLogsAsString), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Command);
		}
#pragma warning restore 0169

		IntPtr id_getCommand;
		public unsafe string? Command {
			get {
				if (id_getCommand == IntPtr.Zero)
					id_getCommand = JNIEnv.GetMethodID (class_ref, "getCommand", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommand), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.CreateTime);
		}
#pragma warning restore 0169

		IntPtr id_getCreateTime;
		public unsafe global::Java.Util.Date? CreateTime {
			get {
				if (id_getCreateTime == IntPtr.Zero)
					id_getCreateTime = JNIEnv.GetMethodID (class_ref, "getCreateTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateTime), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe long Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.EndTime);
		}
#pragma warning restore 0169

		IntPtr id_getEndTime;
		public unsafe global::Java.Util.Date? EndTime {
			get {
				if (id_getEndTime == IntPtr.Zero)
					id_getEndTime = JNIEnv.GetMethodID (class_ref, "getEndTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndTime), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.FailStackTrace);
		}
#pragma warning restore 0169

		IntPtr id_getFailStackTrace;
		public unsafe string? FailStackTrace {
			get {
				if (id_getFailStackTrace == IntPtr.Zero)
					id_getFailStackTrace = JNIEnv.GetMethodID (class_ref, "getFailStackTrace", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFailStackTrace), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Future);
		}
#pragma warning restore 0169

		IntPtr id_getFuture;
		public unsafe global::Java.Util.Concurrent.IFuture? Future {
			get {
				if (id_getFuture == IntPtr.Zero)
					id_getFuture = JNIEnv.GetMethodID (class_ref, "getFuture", "()Ljava/util/concurrent/Future;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFuture), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFmpeg;
		}
#pragma warning restore 0169

		IntPtr id_isFFmpeg;
		public unsafe bool IsFFmpeg {
			get {
				if (id_isFFmpeg == IntPtr.Zero)
					id_isFFmpeg = JNIEnv.GetMethodID (class_ref, "isFFmpeg", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFFmpeg);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsFFprobe;
		}
#pragma warning restore 0169

		IntPtr id_isFFprobe;
		public unsafe bool IsFFprobe {
			get {
				if (id_isFFprobe == IntPtr.Zero)
					id_isFFprobe = JNIEnv.GetMethodID (class_ref, "isFFprobe", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFFprobe);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsMediaInformation;
		}
#pragma warning restore 0169

		IntPtr id_isMediaInformation;
		public unsafe bool IsMediaInformation {
			get {
				if (id_isMediaInformation == IntPtr.Zero)
					id_isMediaInformation = JNIEnv.GetMethodID (class_ref, "isMediaInformation", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMediaInformation);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LogCallback);
		}
#pragma warning restore 0169

		IntPtr id_getLogCallback;
		public unsafe global::Com.Arthenica.Ffmpegkit.ILogCallback? LogCallback {
			get {
				if (id_getLogCallback == IntPtr.Zero)
					id_getLogCallback = JNIEnv.GetMethodID (class_ref, "getLogCallback", "()Lcom/arthenica/ffmpegkit/LogCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ILogCallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogCallback), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LogRedirectionStrategy);
		}
#pragma warning restore 0169

		IntPtr id_getLogRedirectionStrategy;
		public unsafe global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? LogRedirectionStrategy {
			get {
				if (id_getLogRedirectionStrategy == IntPtr.Zero)
					id_getLogRedirectionStrategy = JNIEnv.GetMethodID (class_ref, "getLogRedirectionStrategy", "()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;");
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogRedirectionStrategy), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.Logs);
		}
#pragma warning restore 0169

		IntPtr id_getLogs;
		public unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? Logs {
			get {
				if (id_getLogs == IntPtr.Zero)
					id_getLogs = JNIEnv.GetMethodID (class_ref, "getLogs", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogs), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.LogsAsString);
		}
#pragma warning restore 0169

		IntPtr id_getLogsAsString;
		public unsafe string? LogsAsString {
			get {
				if (id_getLogsAsString == IntPtr.Zero)
					id_getLogsAsString = JNIEnv.GetMethodID (class_ref, "getLogsAsString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogsAsString), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Output);
		}
#pragma warning restore 0169

		IntPtr id_getOutput;
		public unsafe string? Output {
			get {
				if (id_getOutput == IntPtr.Zero)
					id_getOutput = JNIEnv.GetMethodID (class_ref, "getOutput", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutput), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.ReturnCode);
		}
#pragma warning restore 0169

		IntPtr id_getReturnCode;
		public unsafe global::Com.Arthenica.Ffmpegkit.ReturnCode? ReturnCode {
			get {
				if (id_getReturnCode == IntPtr.Zero)
					id_getReturnCode = JNIEnv.GetMethodID (class_ref, "getReturnCode", "()Lcom/arthenica/ffmpegkit/ReturnCode;");
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ReturnCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReturnCode), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SessionId;
		}
#pragma warning restore 0169

		IntPtr id_getSessionId;
		public unsafe long SessionId {
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		IntPtr id_getStartTime;
		public unsafe global::Java.Util.Date? StartTime {
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartTime), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Arthenica.Ffmpegkit.SessionState? State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/arthenica/ffmpegkit/SessionState;");
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.SessionState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var log = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Log> (native_log, JniHandleOwnership.DoNotTransfer);
			__this.AddLog (log);
		}
#pragma warning restore 0169

		IntPtr id_addLog_Lcom_arthenica_ffmpegkit_Log_;
		public unsafe void AddLog (global::Com.Arthenica.Ffmpegkit.Log? log)
		{
			if (id_addLog_Lcom_arthenica_ffmpegkit_Log_ == IntPtr.Zero)
				id_addLog_Lcom_arthenica_ffmpegkit_Log_ = JNIEnv.GetMethodID (class_ref, "addLog", "(Lcom/arthenica/ffmpegkit/Log;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((log == null) ? IntPtr.Zero : ((global::Java.Lang.Object) log).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLog_Lcom_arthenica_ffmpegkit_Log_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.ToLocalJniHandle (__this.GetAllLogs (waitTimeout));
		}
#pragma warning restore 0169

		IntPtr id_getAllLogs_I;
		public unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.Log>? GetAllLogs (int waitTimeout)
		{
			if (id_getAllLogs_I == IntPtr.Zero)
				id_getAllLogs_I = JNIEnv.GetMethodID (class_ref, "getAllLogs", "(I)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (waitTimeout);
			return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.Log>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllLogs_I, __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GetAllLogsAsString (waitTimeout));
		}
#pragma warning restore 0169

		IntPtr id_getAllLogsAsString_I;
		public unsafe string? GetAllLogsAsString (int waitTimeout)
		{
			if (id_getAllLogsAsString_I == IntPtr.Zero)
				id_getAllLogsAsString_I = JNIEnv.GetMethodID (class_ref, "getAllLogsAsString", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (waitTimeout);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllLogsAsString_I, __args), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewArray (__this.GetArguments ());
		}
#pragma warning restore 0169

		IntPtr id_getArguments;
		public unsafe string[]? GetArguments ()
		{
			if (id_getArguments == IntPtr.Zero)
				id_getArguments = JNIEnv.GetMethodID (class_ref, "getArguments", "()[Ljava/lang/String;");
			return (string[]?) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArguments), JniHandleOwnership.TransferLocalRef, typeof (string));
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.ThereAreAsynchronousMessagesInTransmit ();
		}
#pragma warning restore 0169

		IntPtr id_thereAreAsynchronousMessagesInTransmit;
		public unsafe bool ThereAreAsynchronousMessagesInTransmit ()
		{
			if (id_thereAreAsynchronousMessagesInTransmit == IntPtr.Zero)
				id_thereAreAsynchronousMessagesInTransmit = JNIEnv.GetMethodID (class_ref, "thereAreAsynchronousMessagesInTransmit", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_thereAreAsynchronousMessagesInTransmit);
		}

	}
}
