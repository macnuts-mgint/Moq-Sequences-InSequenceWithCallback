using System.Threading;

using NUnit.Framework;
using System.Threading.Tasks;

namespace Moq.Sequences.Tests {
	public class SequenceWithActionTest {
		private Mock<I> mock;

		[SetUp]
		public void SetUp() {
			mock = new Mock<I>();
		}

		[Test]
		public void Loop_with_prior_missing_call() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method0()).InSequenceWithCallback(() => { });

				using (Sequence.Loop(Times.Exactly(1))) {
					mock.Setup(_ => _.Method1(It.IsAny<int>())).InSequenceWithCallback((int _) => { });
				}

				Assert.Throws<SequenceException>(() => mock.Object.Method1());
			}
		}

		[Test]
		public void Loop_steps_with_non_loop_steps() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method2(It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2) => { });

				using (Sequence.Loop(Times.Exactly(1))) {
					mock.Setup(_ => _.Method3(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3) => { });
				}

				mock.Setup(_ => _.Method4(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4) => { });

				mock.Object.Method2();
				mock.Object.Method3();
				mock.Object.Method4();
			}
		}

		[Test]
		public void Nested_loops() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method5(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5) => { });

				using (Sequence.Loop(Times.Exactly(1))) {
					mock.Setup(_ => _.Method6(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6) => { });

					using (Sequence.Loop(Times.Exactly(1))) {
						mock.Setup(_ => _.Method7(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7) => { });
					}
				}

				mock.Object.Method5();
				mock.Object.Method6();
				mock.Object.Method7();
			}
		}

		[Test]
		public void Empty_sequence_is_ignored() {
			using (Sequence.Create()) {
			}
		}

		[Test]
		public void Explicit_MockSequence_Dispose_is_ignored() {
			using (var sequence = Sequence.Create()) {
				sequence.Dispose();
				sequence.Dispose();
				sequence.Dispose();
			}
		}

		[Test]
		public void Method_call_in_sequence() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method8(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8) => { });
				mock.Setup(_ => _.Method9(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9) => { });

				mock.Object.Method8();
				mock.Object.Method9();
			}
		}

		[Test]
		public void Method_call_out_of_sequence() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method10(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10) => { }, Times.AtMostOnce());
				mock.Setup(_ => _.Method11(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11) => { });

				mock.Object.Method11();
				Assert.Throws<SequenceException>(() => mock.Object.Method10());
			}
		}

		[Test]
		public void Method_call_before_previous_one_verified() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method12(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12) => { });
				mock.Setup(_ => _.Method13(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12, int _13) => { });

				Assert.Throws<SequenceException>(() => mock.Object.Method13());
			}
		}

		[Test]
		public void Property_get_in_sequence() {
			using (Sequence.Create()) {
				mock.SetupGet(_ => _.Property1).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());
				mock.SetupGet(_ => _.Property2).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());

				var foo = mock.Object.Property1;
				foo = mock.Object.Property2;
			}
		}

		[Test]
		public void Property_get_out_of_sequence() {
			using (Sequence.Create()) {
				mock.SetupGet(_ => _.Property1).InSequenceWithCallback(() => { }, Times.AtMostOnce()).Returns(It.IsAny<int>());
				mock.SetupGet(_ => _.Property2).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());

				int foo = mock.Object.Property2;
				Assert.Throws<SequenceException>(() => foo = mock.Object.Property1);
			}
		}

		[Test]
		public void Property_get_before_previous_one_verified() {
			using (Sequence.Create()) {
				mock.SetupGet(_ => _.Property1).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());
				mock.SetupGet(_ => _.Property2).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());

				int foo;
				Assert.Throws<SequenceException>(() => foo = mock.Object.Property2);
			}
		}

		[Test]
		public void Property_get_via_Setup() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Property1).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());
				mock.Setup(_ => _.Property2).InSequenceWithCallback(() => { }).Returns(It.IsAny<int>());

				var foo = mock.Object.Property1;
				foo = mock.Object.Property2;
			}
		}

		[Test]
		public void Property_set_in_sequence() {
			using (Sequence.Create()) {
				mock.SetupSet(_ => _.Property1 = 0).InSequenceWithCallback(() => { });
				mock.SetupSet(_ => _.Property2 = 0).InSequenceWithCallback(() => { });

				mock.Object.Property1 = 0;
				mock.Object.Property2 = 0;
			}
		}

		[Test]
		public void Property_set_out_of_sequence() {
			using (Sequence.Create()) {
				mock.SetupSet(_ => _.Property1 = 0).InSequenceWithCallback(() => { }, Times.AtMostOnce());
				mock.SetupSet(_ => _.Property2 = 0).InSequenceWithCallback(() => { });

				mock.Object.Property2 = 0;
				Assert.Throws<SequenceException>(() => mock.Object.Property1 = 0);
			}
		}

		[Test]
		public void Property_set_before_previous_one_verified() {
			using (Sequence.Create()) {
				mock.SetupSet(_ => _.Property1 = 0).InSequenceWithCallback(() => { });
				mock.SetupSet(_ => _.Property2 = 0).InSequenceWithCallback(() => { });

				Assert.Throws<SequenceException>(() => mock.Object.Property2 = 0);
			}
		}

		[Test]
		public void Multiple_mocks_in_same_sequence() {
			var mock1 = new Mock<I>();
			var mock2 = new Mock<I>();

			using (Sequence.Create()) {
				mock1.Setup(_ => _.Method14(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12, int _13, int _14) => { });
				mock2.Setup(_ => _.Method14(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12, int _13, int _14) => { });

				Assert.Throws<SequenceException>(() => mock2.Object.Method14());
			}
		}

		[Test]
		public void Enforce_active_sequence_for_Setup_InSequence_extension() {
			Assert.Throws<SequenceUsageException>(() => mock.Setup(_ => _.Method15(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12, int _13, int _14, int _15) => { }));
		}

		[Test]
		public void Enforce_active_sequence_for_mock_calls_within_sequences() {
			using (Sequence.Create()) {
				mock.Setup(_ => _.Method16(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).InSequenceWithCallback((int _1, int _2, int _3, int _4, int _5, int _6, int _7, int _8, int _9, int _10, int _11, int _12, int _13, int _14, int _15, int _16) => { }, Times.AtMostOnce());
			}

			Assert.Throws<SequenceUsageException>(() => mock.Object.Method16());
		}

		[Test]
		public void Enforce_mock_calls_outside_sequences_if_mock_is_strict() {
			var strictMock = new Mock<I>(MockBehavior.Strict);

			using (Sequence.Create()) {
			}

			Assert.Throws<MockException>(() => strictMock.Object.Method1());
		}

		[Test]
		public void Enforce_active_sequence_for_loop() {
			Assert.Throws<SequenceUsageException>(() => Sequence.Loop());
		}

		[Test]
		public void Enforce_only_one_active_sequence() {
			using (Sequence.Create()) {
				Assert.Throws<SequenceUsageException>(() => Sequence.Create());
			}
		}

		[Test]
		public void Enforce_that_loops_must_be_disposed() {
			Assert.Throws<SequenceUsageException>(delegate
			{
				using (Sequence.Create()) {
					Sequence.Loop();
				}
			});
		}

		[Test]
		public void Enforce_that_all_steps_in_a_sequence_must_be_completed() {
			Assert.Throws<SequenceException>(delegate
			{
				using (Sequence.Create()) {
					mock.Setup(_ => _.Method0()).InSequenceWithCallback(() => { });
				}
			});
		}

		[Test]
		public void Support_multiple_sequences_in_different_threads() {
			var mock1 = new Mock<I>();
			var mock2 = new Mock<I>();

			using (Sequence.Create()) {
				mock1.Setup(_ => _.Method0()).InSequenceWithCallback(() => { });
				mock1.Setup(_ => _.Method1(It.IsAny<int>())).InSequenceWithCallback((int _) => { });

				var calledOnThread = new AutoResetEvent(false);
				var calledOnMain = new AutoResetEvent(false);

				new Thread(() =>
				{
					using (Sequence.Create()) {
						mock2.Setup(_ => _.Method0()).InSequenceWithCallback(() => { });
						mock2.Setup(_ => _.Method1(It.IsAny<int>())).InSequenceWithCallback((int _) => { });

						calledOnMain.WaitOne();
						mock2.Object.Method0();
						calledOnThread.Set();

						calledOnMain.WaitOne();
						mock2.Object.Method1();
						calledOnThread.Set();
					}
				}).Start();

				mock1.Object.Method0();
				calledOnMain.Set();

				calledOnThread.WaitOne();
				mock1.Object.Method1();
				calledOnMain.Set();
			}
		}

		public interface I {
			void Method0();
			void Method1(int _ = 0);
			void Method2(int _1 = 0, int _2 = 0);
			void Method3(int _1 = 0, int _2 = 0, int _3 = 0);
			void Method4(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0);
			void Method5(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0);
			void Method6(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0);
			void Method7(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0);
			void Method8(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0);
			void Method9(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0);
			void Method10(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0);
			void Method11(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0);
			void Method12(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0, int _12 = 0);
			void Method13(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0, int _12 = 0, int _13 = 0);
			void Method14(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0, int _12 = 0, int _13 = 0, int _14 = 0);
			void Method15(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0, int _12 = 0, int _13 = 0, int _14 = 0, int _15 = 0);
			void Method16(int _1 = 0, int _2 = 0, int _3 = 0, int _4 = 0, int _5 = 0, int _6 = 0, int _7 = 0, int _8 = 0, int _9 = 0, int _10 = 0, int _11 = 0, int _12 = 0, int _13 = 0, int _14 = 0, int _15 = 0, int _16 = 0);
			int Property1 { get; set; }
			int Property2 { get; set; }
		}
	}
}
