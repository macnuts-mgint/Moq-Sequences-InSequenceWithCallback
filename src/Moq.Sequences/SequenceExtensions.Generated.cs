using System;
using Moq.Language.Flow;
namespace Moq.Sequences {
	public static partial class SequenceExtensions {
		public static ISetupGetter<T, TProperty> InSequenceWithCallback<T, TProperty>(this ISetupGetter<T, TProperty> setup, Action callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetupGetter<T, TProperty> InSequenceWithCallback<T, TProperty>(this ISetupGetter<T, TProperty> setup, Action callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, TResult>(ISetupGetter<T, TResult> setup, Action callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback(() => { Sequence.Record(step); callback(); });
		}
		public static ISetup<T> InSequenceWithCallback<T>(this ISetup<T> setup, Action callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T>(this ISetup<T> setup, Action callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult>(this ISetup<T, TResult> setup, Action callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult>(this ISetup<T, TResult> setup, Action callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T>(ISetup<T> setup, Action callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback(() => { Sequence.Record(step); callback(); });
		}
		internal static void AddStep<T, TResult>(ISetup<T, TResult> setup, Action callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback(() => { Sequence.Record(step); callback(); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1>(this ISetup<T> setup, Action<T1> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1>(this ISetup<T> setup, Action<T1> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1>(this ISetup<T, TResult> setup, Action<T1> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1>(this ISetup<T, TResult> setup, Action<T1> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1>(ISetup<T> setup, Action<T1> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1) => { Sequence.Record(step); callback(arg1); });
		}
		internal static void AddStep<T, TResult, T1>(ISetup<T, TResult> setup, Action<T1> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1) => { Sequence.Record(step); callback(arg1); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2>(this ISetup<T> setup, Action<T1, T2> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2>(this ISetup<T> setup, Action<T1, T2> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2>(this ISetup<T, TResult> setup, Action<T1, T2> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2>(this ISetup<T, TResult> setup, Action<T1, T2> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2>(ISetup<T> setup, Action<T1, T2> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2) => { Sequence.Record(step); callback(arg1, arg2); });
		}
		internal static void AddStep<T, TResult, T1, T2>(ISetup<T, TResult> setup, Action<T1, T2> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2) => { Sequence.Record(step); callback(arg1, arg2); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3>(this ISetup<T> setup, Action<T1, T2, T3> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3>(this ISetup<T> setup, Action<T1, T2, T3> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3>(this ISetup<T, TResult> setup, Action<T1, T2, T3> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3>(this ISetup<T, TResult> setup, Action<T1, T2, T3> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3>(ISetup<T> setup, Action<T1, T2, T3> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3) => { Sequence.Record(step); callback(arg1, arg2, arg3); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3>(ISetup<T, TResult> setup, Action<T1, T2, T3> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3) => { Sequence.Record(step); callback(arg1, arg2, arg3); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4>(this ISetup<T> setup, Action<T1, T2, T3, T4> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4>(this ISetup<T> setup, Action<T1, T2, T3, T4> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4>(ISetup<T> setup, Action<T1, T2, T3, T4> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5>(ISetup<T> setup, Action<T1, T2, T3, T4, T5> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); });
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T> InSequenceWithCallback<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback) where T : class {
			return InSequenceWithCallback(setup, callback, Times.Once());
		}
		public static ISetup<T, TResult> InSequenceWithCallback<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback, Times expectedCalls) where T : class {
			AddStep(setup, callback, expectedCalls);
			return setup;
		}
		internal static void AddStep<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ISetup<T> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); });
		}
		internal static void AddStep<T, TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ISetup<T, TResult> setup, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> callback, Times expectedCalls) where T : class {
			var step = Sequence.Step(setup, expectedCalls);
			setup.Callback((T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => { Sequence.Record(step); callback(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); });
		}
	}
}
