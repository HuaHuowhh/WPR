using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Arthenica.Ffmpegkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']"
	[global::Android.Runtime.Register ("com/arthenica/ffmpegkit/FFmpegKit", DoNotGenerateAcw=true)]
	public partial class FFmpegKit : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/arthenica/ffmpegkit/FFmpegKit", typeof (FFmpegKit));

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

		protected FFmpegKit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public static unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("cancel", "(J)V", "")]
		public static unsafe void Cancel (long sessionId)
		{
			const string __id = "cancel.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sessionId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("execute", "(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? Execute (string? command)
		{
			const string __id = "execute.(Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_command);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeAsync' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback'] and parameter[5][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				__args [4] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeAsync", "(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteAsync (string? command, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeAsync.(Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_command = JNIEnv.NewString ((string?)command);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_command);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_command);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeWithArguments' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("executeWithArguments", "([Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteWithArguments (string[]? arguments)
		{
			const string __id = "executeWithArguments.([Ljava/lang/String;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arguments);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='com.arthenica.ffmpegkit.LogCallback'] and parameter[4][@type='com.arthenica.ffmpegkit.StatisticsCallback'] and parameter[5][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Com.Arthenica.Ffmpegkit.ILogCallback? logCallback, global::Com.Arthenica.Ffmpegkit.IStatisticsCallback? statisticsCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Lcom/arthenica/ffmpegkit/LogCallback;Lcom/arthenica/ffmpegkit/StatisticsCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((logCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logCallback).Handle);
				__args [3] = new JniArgumentValue ((statisticsCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) statisticsCallback).Handle);
				__args [4] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (logCallback);
				global::System.GC.KeepAlive (statisticsCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='executeWithArgumentsAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.arthenica.ffmpegkit.FFmpegSessionCompleteCallback'] and parameter[3][@type='java.util.concurrent.ExecutorService']]"
		[Register ("executeWithArgumentsAsync", "([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;", "")]
		public static unsafe global::Com.Arthenica.Ffmpegkit.FFmpegSession? ExecuteWithArgumentsAsync (string[]? arguments, global::Com.Arthenica.Ffmpegkit.IFFmpegSessionCompleteCallback? completeCallback, global::Java.Util.Concurrent.IExecutorService? executorService)
		{
			const string __id = "executeWithArgumentsAsync.([Ljava/lang/String;Lcom/arthenica/ffmpegkit/FFmpegSessionCompleteCallback;Ljava/util/concurrent/ExecutorService;)Lcom/arthenica/ffmpegkit/FFmpegSession;";
			IntPtr native_arguments = JNIEnv.NewArray (arguments);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_arguments);
				__args [1] = new JniArgumentValue ((completeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completeCallback).Handle);
				__args [2] = new JniArgumentValue ((executorService == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executorService).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Arthenica.Ffmpegkit.FFmpegSession> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arguments != null) {
					JNIEnv.CopyArray (native_arguments, arguments);
					JNIEnv.DeleteLocalRef (native_arguments);
				}
				global::System.GC.KeepAlive (arguments);
				global::System.GC.KeepAlive (completeCallback);
				global::System.GC.KeepAlive (executorService);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.arthenica.ffmpegkit']/class[@name='FFmpegKit']/method[@name='listSessions' and count(parameter)=0]"
		[Register ("listSessions", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Arthenica.Ffmpegkit.FFmpegSession>? ListSessions ()
		{
			const string __id = "listSessions.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::Com.Arthenica.Ffmpegkit.FFmpegSession>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
