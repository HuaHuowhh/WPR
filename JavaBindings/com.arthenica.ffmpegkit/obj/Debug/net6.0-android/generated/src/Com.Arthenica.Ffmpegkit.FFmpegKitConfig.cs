using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFmpegKitConfig", DoNotGenerateAcw=true)]
	public partial class FFmpegKitConfig : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFmpegKitConfig", typeof (FFmpegKitConfig));

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

		protected FFmpegKitConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe int AsyncConcurrencyLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getAsyncConcurrencyLimit' and count(parameter)=0]"
			[Register ("getAsyncConcurrencyLimit", "()I", "")]
			get {
				const string __id = "getAsyncConcurrencyLimit.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setAsyncConcurrencyLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAsyncConcurrencyLimit", "(I)V", "")]
			set {
				const string __id = "setAsyncConcurrencyLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe string? BuildDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getBuildDate' and count(parameter)=0]"
			[Register ("getBuildDate", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBuildDate.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? FFmpegSessionCompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getFFmpegSessionCompleteCallback' and count(parameter)=0]"
			[Register ("getFFmpegSessionCompleteCallback", "()Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;", "")]
			get {
				const string __id = "getFFmpegSessionCompleteCallback.()Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.FFmpegSession>? FFmpegSessions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getFFmpegSessions' and count(parameter)=0]"
			[Register ("getFFmpegSessions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getFFmpegSessions.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.FFmpegSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? FFmpegVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getFFmpegVersion' and count(parameter)=0]"
			[Register ("getFFmpegVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFFmpegVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? FFprobeSessionCompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getFFprobeSessionCompleteCallback' and count(parameter)=0]"
			[Register ("getFFprobeSessionCompleteCallback", "()Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;", "")]
			get {
				const string __id = "getFFprobeSessionCompleteCallback.()Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.FFprobeSession>? FFprobeSessions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getFFprobeSessions' and count(parameter)=0]"
			[Register ("getFFprobeSessions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getFFprobeSessions.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.FFprobeSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsLTSBuild {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='isLTSBuild' and count(parameter)=0]"
			[Register ("isLTSBuild", "()Z", "")]
			get {
				const string __id = "isLTSBuild.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.ISession? LastCompletedSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getLastCompletedSession' and count(parameter)=0]"
			[Register ("getLastCompletedSession", "()Lcom/arthenica/ffmpegkit/Session;", "")]
			get {
				const string __id = "getLastCompletedSession.()Lcom/arthenica/ffmpegkit/Session;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.ISession? LastSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getLastSession' and count(parameter)=0]"
			[Register ("getLastSession", "()Lcom/arthenica/ffmpegkit/Session;", "")]
			get {
				const string __id = "getLastSession.()Lcom/arthenica/ffmpegkit/Session;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.Level? LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/arthenica/ffmpegkit/Level;", "")]
			get {
				const string __id = "getLogLevel.()Lcom/arthenica/ffmpegkit/Level;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.Level> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Level']]"
			[Register ("setLogLevel", "(Lcom/arthenica/ffmpegkit/Level;)V", "")]
			set {
				const string __id = "setLogLevel.(Lcom/arthenica/ffmpegkit/Level;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy? LogRedirectionStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getLogRedirectionStrategy' and count(parameter)=0]"
			[Register ("getLogRedirectionStrategy", "()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;", "")]
			get {
				const string __id = "getLogRedirectionStrategy.()Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.LogRedirectionStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setLogRedirectionStrategy' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.LogRedirectionStrategy']]"
			[Register ("setLogRedirectionStrategy", "(Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V", "")]
			set {
				const string __id = "setLogRedirectionStrategy.(Lcom/arthenica/ffmpegkit/LogRedirectionStrategy;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? MediaInformationSessionCompleteCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getMediaInformationSessionCompleteCallback' and count(parameter)=0]"
			[Register ("getMediaInformationSessionCompleteCallback", "()Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;", "")]
			get {
				const string __id = "getMediaInformationSessionCompleteCallback.()Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.MediaInformationSession>? MediaInformationSessions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getMediaInformationSessions' and count(parameter)=0]"
			[Register ("getMediaInformationSessions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getMediaInformationSessions.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.MediaInformationSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int SessionHistorySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSessionHistorySize' and count(parameter)=0]"
			[Register ("getSessionHistorySize", "()I", "")]
			get {
				const string __id = "getSessionHistorySize.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setSessionHistorySize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSessionHistorySize", "(I)V", "")]
			set {
				const string __id = "setSessionHistorySize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.ISession>? Sessions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSessions' and count(parameter)=0]"
			[Register ("getSessions", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSessions.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.ISession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string? Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='argumentsToString' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("argumentsToString", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? ArgumentsToString (string[]? arguments)
		{
			const string __id = "argumentsToString.([Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arguments);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncFFmpegExecute' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFmpegSession']]"
		[Register ("asyncFFmpegExecute", "(Lcom/arthenica/ffmpegkit/FFmpegSession;)V", "")]
		public static unsafe void AsyncFFmpegExecute (global::Com.Arthenica.Ffmpegkit.FFmpegSession? ffmpegSession)
		{
			const string __id = "asyncFFmpegExecute.(Lcom/arthenica/ffmpegkit/FFmpegSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffmpegSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffmpegSession).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffmpegSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncFFmpegExecute' and count(parameter)=2 and parameter[1][@type='com.arthenica.ffmpegkit.FFmpegSession'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
		[Register ("asyncFFmpegExecute", "(Lcom/arthenica/ffmpegkit/FFmpegSession;Ljava/util/concurrent/ExecutorService;)V", "")]
		public static unsafe void AsyncFFmpegExecute (global::Com.Arthenica.Ffmpegkit.FFmpegSession? ffmpegSession, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "asyncFFmpegExecute.(Lcom/arthenica/ffmpegkit/FFmpegSession;Ljava/util/concurrent/ExecutorService;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ffmpegSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffmpegSession).Handle);
				__args [1] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffmpegSession);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncFFprobeExecute' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFprobeSession']]"
		[Register ("asyncFFprobeExecute", "(Lcom/arthenica/ffmpegkit/FFprobeSession;)V", "")]
		public static unsafe void AsyncFFprobeExecute (global::Com.Arthenica.Ffmpegkit.FFprobeSession? ffprobeSession)
		{
			const string __id = "asyncFFprobeExecute.(Lcom/arthenica/ffmpegkit/FFprobeSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffprobeSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffprobeSession).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffprobeSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncFFprobeExecute' and count(parameter)=2 and parameter[1][@type='com.arthenica.ffmpegkit.FFprobeSession'] and parameter[2][@type='java.util.concurrent.ExecutorService']]"
		[Register ("asyncFFprobeExecute", "(Lcom/arthenica/ffmpegkit/FFprobeSession;Ljava/util/concurrent/ExecutorService;)V", "")]
		public static unsafe void AsyncFFprobeExecute (global::Com.Arthenica.Ffmpegkit.FFprobeSession? ffprobeSession, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "asyncFFprobeExecute.(Lcom/arthenica/ffmpegkit/FFprobeSession;Ljava/util/concurrent/ExecutorService;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ffprobeSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffprobeSession).Handle);
				__args [1] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffprobeSession);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncGetMediaInformationExecute' and count(parameter)=2 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSession'] and parameter[2][@type='int']]"
		[Register ("asyncGetMediaInformationExecute", "(Lcom/arthenica/ffmpegkit/MediaInformationSession;I)V", "")]
		public static unsafe void AsyncGetMediaInformationExecute (global::Com.Arthenica.Ffmpegkit.MediaInformationSession? mediaInformationSession, int waitTimeout)
		{
			const string __id = "asyncGetMediaInformationExecute.(Lcom/arthenica/ffmpegkit/MediaInformationSession;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaInformationSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSession).Handle);
				__args [1] = new JniArgumentValue (waitTimeout);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='asyncGetMediaInformationExecute' and count(parameter)=3 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSession'] and parameter[2][@type='java.util.concurrent.ExecutorService'] and parameter[3][@type='int']]"
		[Register ("asyncGetMediaInformationExecute", "(Lcom/arthenica/ffmpegkit/MediaInformationSession;Ljava/util/concurrent/ExecutorService;I)V", "")]
		public static unsafe void AsyncGetMediaInformationExecute (global::Com.Arthenica.Ffmpegkit.MediaInformationSession? mediaInformationSession, global::Java.Util.Concurrent.IExecutorService? executorService, int waitTimeout)
		{
			const string __id = "asyncGetMediaInformationExecute.(Lcom/arthenica/ffmpegkit/MediaInformationSession;Ljava/util/concurrent/ExecutorService;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mediaInformationSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSession).Handle);
				__args [1] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				__args [2] = new JniArgumentValue (waitTimeout);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSession);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='clearSessions' and count(parameter)=0]"
		[Register ("clearSessions", "()V", "")]
		public static unsafe void ClearSessions ()
		{
			const string __id = "clearSessions.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='closeFFmpegPipe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("closeFFmpegPipe", "(Ljava/lang/String;)V", "")]
		public static unsafe void CloseFFmpegPipe (string? ffmpegPipePath)
		{
			const string __id = "closeFFmpegPipe.(Ljava/lang/String;)V";
			IntPtr native_ffmpegPipePath = JNIEnv.NewString ((string?)ffmpegPipePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ffmpegPipePath);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ffmpegPipePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='disableRedirection' and count(parameter)=0]"
		[Register ("disableRedirection", "()V", "")]
		public static unsafe void DisableRedirection ()
		{
			const string __id = "disableRedirection.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableFFmpegSessionCompleteCallback' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback']]"
		[Register ("enableFFmpegSessionCompleteCallback", "(Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)V", "")]
		public static unsafe void EnableFFmpegSessionCompleteCallback (global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? ffmpegSessionCompleteCallback)
		{
			const string __id = "enableFFmpegSessionCompleteCallback.(Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffmpegSessionCompleteCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffmpegSessionCompleteCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffmpegSessionCompleteCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableFFprobeSessionCompleteCallback' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFprobeSessionCompleteCallback']]"
		[Register ("enableFFprobeSessionCompleteCallback", "(Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)V", "")]
		public static unsafe void EnableFFprobeSessionCompleteCallback (global::Com.Arthenica.Ffmpegkit.IFFprobeSessionCompleteCallback? ffprobeSessionCompleteCallback)
		{
			const string __id = "enableFFprobeSessionCompleteCallback.(Lcom/arthenica/ffmpegkit/FFprobeSessionCompleteCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffprobeSessionCompleteCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffprobeSessionCompleteCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffprobeSessionCompleteCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableLogCallback' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.LogCallback']]"
		[Register ("enableLogCallback", "(Lcom/arthenica/ffmpegkit/LogCallback;)V", "")]
		public static unsafe void EnableLogCallback (global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback)
		{
			const string __id = "enableLogCallback.(Lcom/arthenica/ffmpegkit/LogCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (logCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableMediaInformationSessionCompleteCallback' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSessionCompleteCallback']]"
		[Register ("enableMediaInformationSessionCompleteCallback", "(Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)V", "")]
		public static unsafe void EnableMediaInformationSessionCompleteCallback (global::Com.Arthenica.Ffmpegkit.IMediaInformationSessionCompleteCallback? mediaInformationSessionCompleteCallback)
		{
			const string __id = "enableMediaInformationSessionCompleteCallback.(Lcom/arthenica/ffmpegkit/MediaInformationSessionCompleteCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaInformationSessionCompleteCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSessionCompleteCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSessionCompleteCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableRedirection' and count(parameter)=0]"
		[Register ("enableRedirection", "()V", "")]
		public static unsafe void EnableRedirection ()
		{
			const string __id = "enableRedirection.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='enableStatisticsCallback' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.StatisticsCallback']]"
		[Register ("enableStatisticsCallback", "(Lcom/arthenica/ffmpegkit/StatisticsCallback;)V", "")]
		public static unsafe void EnableStatisticsCallback (global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback)
		{
			const string __id = "enableStatisticsCallback.(Lcom/arthenica/ffmpegkit/StatisticsCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (statisticsCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='ffmpegExecute' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFmpegSession']]"
		[Register ("ffmpegExecute", "(Lcom/arthenica/ffmpegkit/FFmpegSession;)V", "")]
		public static unsafe void FfmpegExecute (global::Com.Arthenica.Ffmpegkit.FFmpegSession? ffmpegSession)
		{
			const string __id = "ffmpegExecute.(Lcom/arthenica/ffmpegkit/FFmpegSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffmpegSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffmpegSession).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffmpegSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='ffprobeExecute' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.FFprobeSession']]"
		[Register ("ffprobeExecute", "(Lcom/arthenica/ffmpegkit/FFprobeSession;)V", "")]
		public static unsafe void FfprobeExecute (global::Com.Arthenica.Ffmpegkit.FFprobeSession? ffprobeSession)
		{
			const string __id = "ffprobeExecute.(Lcom/arthenica/ffmpegkit/FFprobeSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ffprobeSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ffprobeSession).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (ffprobeSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getMediaInformationExecute' and count(parameter)=2 and parameter[1][@type='com.arthenica.ffmpegkit.MediaInformationSession'] and parameter[2][@type='int']]"
		[Register ("getMediaInformationExecute", "(Lcom/arthenica/ffmpegkit/MediaInformationSession;I)V", "")]
		public static unsafe void GetMediaInformationExecute (global::Com.Arthenica.Ffmpegkit.MediaInformationSession? mediaInformationSession, int waitTimeout)
		{
			const string __id = "getMediaInformationExecute.(Lcom/arthenica/ffmpegkit/MediaInformationSession;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaInformationSession == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaInformationSession).Handle);
				__args [1] = new JniArgumentValue (waitTimeout);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (mediaInformationSession);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSafParameter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("getSafParameter", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string? GetSafParameter (global::Android.Content.Context? context, global::Android.Net.Uri? uri, string? openMode)
		{
			const string __id = "getSafParameter.(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_openMode = JNIEnv.NewString ((string?)openMode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (native_openMode);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_openMode);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSafParameterForRead' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getSafParameterForRead", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string? GetSafParameterForRead (global::Android.Content.Context? context, global::Android.Net.Uri? uri)
		{
			const string __id = "getSafParameterForRead.(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSafParameterForWrite' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getSafParameterForWrite", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string? GetSafParameterForWrite (global::Android.Content.Context? context, global::Android.Net.Uri? uri)
		{
			const string __id = "getSafParameterForWrite.(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSession' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getSession", "(J)Lcom/arthenica/ffmpegkit/Session;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.ISession? GetSession (long sessionId)
		{
			const string __id = "getSession.(J)Lcom/arthenica/ffmpegkit/Session;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sessionId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.ISession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSessionsByState' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.SessionState']]"
		[Register ("getSessionsByState", "(Lcom/arthenica/ffmpegkit/SessionState;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.ISession>? GetSessionsByState (global::Com.Arthenica.Ffmpegkit.SessionState? state)
		{
			const string __id = "getSessionsByState.(Lcom/arthenica/ffmpegkit/SessionState;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.ISession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (state);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='getSupportedCameraIds' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSupportedCameraIds", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string>? GetSupportedCameraIds (global::Android.Content.Context? context)
		{
			const string __id = "getSupportedCameraIds.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='ignoreSignal' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.Signal']]"
		[Register ("ignoreSignal", "(Lcom/arthenica/ffmpegkit/Signal;)V", "")]
		public static unsafe void IgnoreSignal (global::Com.Arthenica.Ffmpegkit.Signal? signal)
		{
			const string __id = "ignoreSignal.(Lcom/arthenica/ffmpegkit/Signal;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((signal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signal).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (signal);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='messagesInTransmit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("messagesInTransmit", "(J)I", "")]
		public static unsafe int MessagesInTransmit (long sessionId)
		{
			const string __id = "messagesInTransmit.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sessionId);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='parseArguments' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseArguments", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[]? ParseArguments (string? command)
		{
			const string __id = "parseArguments.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_command);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='printToLogcat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("printToLogcat", "(ILjava/lang/String;)V", "")]
		public static unsafe void PrintToLogcat (int logPriority, string? @string)
		{
			const string __id = "printToLogcat.(ILjava/lang/String;)V";
			IntPtr native__string = JNIEnv.NewString ((string?)@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (logPriority);
				__args [1] = new JniArgumentValue (native__string);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='registerNewFFmpegPipe' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerNewFFmpegPipe", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string? RegisterNewFFmpegPipe (global::Android.Content.Context? context)
		{
			const string __id = "registerNewFFmpegPipe.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='sessionStateToString' and count(parameter)=1 and parameter[1][@type='com.arthenica.ffmpegkit.SessionState']]"
		[Register ("sessionStateToString", "(Lcom/arthenica/ffmpegkit/SessionState;)Ljava/lang/String;", "")]
		public static unsafe string? SessionStateToString (global::Com.Arthenica.Ffmpegkit.SessionState? state)
		{
			const string __id = "sessionStateToString.(Lcom/arthenica/ffmpegkit/SessionState;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (state);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setEnvironmentVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEnvironmentVariable", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int SetEnvironmentVariable (string? variableName, string? variableValue)
		{
			const string __id = "setEnvironmentVariable.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_variableName = JNIEnv.NewString ((string?)variableName);
			IntPtr native_variableValue = JNIEnv.NewString ((string?)variableValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_variableName);
				__args [1] = new JniArgumentValue (native_variableValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_variableName);
				JNIEnv.DeleteLocalRef (native_variableValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setFontDirectory' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setFontDirectory", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void SetFontDirectory (global::Android.Content.Context? context, string? fontDirectoryPath, global::System.Collections.Generic.IDictionary<string, string>? fontNameMapping)
		{
			const string __id = "setFontDirectory.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_fontDirectoryPath = JNIEnv.NewString ((string?)fontDirectoryPath);
			IntPtr native_fontNameMapping = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (fontNameMapping);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_fontDirectoryPath);
				__args [2] = new JniArgumentValue (native_fontNameMapping);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fontDirectoryPath);
				JNIEnv.DeleteLocalRef (native_fontNameMapping);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (fontNameMapping);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setFontDirectoryList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setFontDirectoryList", "(Landroid/content/Context;Ljava/util/List;Ljava/util/Map;)V", "")]
		public static unsafe void SetFontDirectoryList (global::Android.Content.Context? context, global::System.Collections.Generic.IList<string>? fontDirectoryList, global::System.Collections.Generic.IDictionary<string, string>? fontNameMapping)
		{
			const string __id = "setFontDirectoryList.(Landroid/content/Context;Ljava/util/List;Ljava/util/Map;)V";
			IntPtr native_fontDirectoryList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (fontDirectoryList);
			IntPtr native_fontNameMapping = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (fontNameMapping);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_fontDirectoryList);
				__args [2] = new JniArgumentValue (native_fontNameMapping);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fontDirectoryList);
				JNIEnv.DeleteLocalRef (native_fontNameMapping);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (fontDirectoryList);
				global::System.GC.KeepAlive (fontNameMapping);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKitConfig']/method[@name='setFontconfigConfigurationPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFontconfigConfigurationPath", "(Ljava/lang/String;)I", "")]
		public static unsafe int SetFontconfigConfigurationPath (string? path)
		{
			const string __id = "setFontconfigConfigurationPath.(Ljava/lang/String;)I";
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
