using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using birdAviarymanagement;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

namespace TestProject2
{
    [TestClass]
    public sealed class BirdAviaryManagementTests
    {
        [TestMethod]
        public void AvgCalc_WithMultipleBirds_ReturnsAverageAge()
        {
            int currentYear = DateTime.Now.Year;
            var birds = new List<Bird>
            {
                new Bird("57", "יונה", "Yellow", 2020, "בבידוד", true),
                new Bird("58", "תוכי", "Yellow", 2022, "בבידוד", true),
                new Bird("59", "יונה", "Yellow", 2018, "בבידוד", true)
            };
            float expected = ((currentYear - 2020) + (currentYear - 2022) + (currentYear - 2018)) / 3f;

            float result = Form1.AvgCalc(birds);

            Assert.AreEqual(expected, result, 0.01f);
        }

        [TestMethod]
        public void AvgCalc_WithOneBird_ReturnsCorrectAge()
        {
            int currentYear = DateTime.Now.Year;
            var birds = new List<Bird>
            {
                new Bird("57", "יונה", "Yellow", 2020, "בבידוד", true)
            };

            float result = Form1.AvgCalc(birds);

            Assert.AreEqual(currentYear - 2020, result, 0.01f);
        }

        [TestMethod]
        public void AvgCalc_WithEmptyList_ReturnsZero()
        {
            float result = Form1.AvgCalc(new List<Bird>());

            Assert.AreEqual(0, result, 0.01f);
        }

        [TestMethod]
        public void AvgCalc_WithNullList_ReturnsZero()
        {
            float result = Form1.AvgCalc(null);

            Assert.AreEqual(0, result, 0.01f);
        }

        [TestMethod]
        public void CountAvailableBirds_WithMixedAvailability_ReturnsOnlyAvailableCount()
        {
            var birds = new List<Bird>
            {
                new Bird("1", "תוכי", "Blue", 2020, "בבית הגידול", true),
                new Bird("2", "יונה", "Green", 2021, "בבידוד", false),
                new Bird("3", "נשר", "White", 2022, "בבית הגידול", true)
            };

            int result = Form1.CountAvailableBirds(birds);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountAvailableBirds_WithEmptyList_ReturnsZero()
        {
            int result = Form1.CountAvailableBirds(new List<Bird>());

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BubbleSortBirdsByYear_SortsByYearDescending()
        {
            var birds = CreateUnsortedBirds();

            List<Bird> sorted = Form1.BubbleSortBirdsByYear(birds);

            AssertYearsAreDescending(sorted);
            Assert.AreEqual(2024, sorted[0].HatchYear);
            Assert.AreEqual(2020, sorted[1].HatchYear);
            Assert.AreEqual(2018, sorted[2].HatchYear);
        }

        [TestMethod]
        public void BubbleSortBirdsByYear_DoesNotLoseRecords()
        {
            var birds = CreateUnsortedBirds();
            int expectedCount = birds.Count;

            List<Bird> sorted = Form1.BubbleSortBirdsByYear(birds);

            Assert.HasCount(expectedCount, sorted);
            CollectionAssert.AreEquivalent(
                new[] { "1", "2", "3" },
                sorted.ConvertAll(bird => bird.RingId));
        }

        [TestMethod]
        public void QuickSortBirdsByYear_SortsByYearDescending()
        {
            var birds = CreateUnsortedBirds();

            List<Bird> sorted = Form1.QuickSortBirdsByYear(birds);

            AssertYearsAreDescending(sorted);
            Assert.AreEqual(2024, sorted[0].HatchYear);
            Assert.AreEqual(2020, sorted[1].HatchYear);
            Assert.AreEqual(2018, sorted[2].HatchYear);
        }

        [TestMethod]
        public void QuickSortBirdsByYear_DoesNotLoseRecords()
        {
            var birds = CreateUnsortedBirds();
            int expectedCount = birds.Count;

            List<Bird> sorted = Form1.QuickSortBirdsByYear(birds);

            Assert.HasCount(expectedCount, sorted);
            CollectionAssert.AreEquivalent(
                new[] { "1", "2", "3" },
                sorted.ConvertAll(bird => bird.RingId));
        }

        [TestMethod]
        public void QuickSortBirdsByYear_WithDuplicateYears_KeepsDescendingOrder()
        {
            var birds = new List<Bird>
            {
                new Bird("1", "תוכי", "Blue", 2020, "בבידוד", true),
                new Bird("2", "יונה", "Green", 2024, "בבידוד", true),
                new Bird("3", "נשר", "White", 2024, "בבידוד", true),
                new Bird("4", "קנרית", "Yellow", 2018, "בבידוד", false)
            };

            List<Bird> sorted = Form1.QuickSortBirdsByYear(birds);

            AssertYearsAreDescending(sorted);
            Assert.HasCount(4, sorted);
        }

        [TestMethod]
        public void QuickSortBirdsByYear_WithEmptyList_ReturnsEmptyList()
        {
            var birds = new List<Bird>();

            List<Bird> sorted = Form1.QuickSortBirdsByYear(birds);

            Assert.IsNotNull(sorted);
            Assert.IsEmpty(sorted);
        }

        [TestMethod]
        public void QuickSortBirdsByYear_WithTenThousandBirds_CompletesUnderNineSeconds()
        {
            var birds = CreateManyBirds(10000);
            var stopwatch = Stopwatch.StartNew();

            List<Bird> sorted = Form1.QuickSortBirdsByYear(birds);

            stopwatch.Stop();
            Assert.HasCount(10000, sorted);
            AssertYearsAreDescending(sorted);
            Assert.IsLessThan(
                9000,
                stopwatch.ElapsedMilliseconds,
                "QuickSort should sort 10,000 birds in under 9 seconds.");
        }

        [TestMethod]
        public void UpdateBirdAvailability_WhenHealthy_SetsAvailableToTrue()
        {
            var bird = new Bird("1", "תוכי", "Blue", 2020, "בבידוד", false);
            var mockService = new Mock<IHealthService>();
            mockService.Setup(service => service.IsBirdHealthy("1")).Returns(true);

            Form1.UpdateBirdAvailability(bird, mockService.Object);

            Assert.IsTrue(bird.AvailableForSale);
            mockService.Verify(service => service.IsBirdHealthy("1"), Times.Once);
        }

        [TestMethod]
        public void UpdateBirdAvailability_WhenNotHealthy_SetsAvailableToFalse()
        {
            var bird = new Bird("1", "תוכי", "Blue", 2020, "בבידוד", true);
            var mockService = new Mock<IHealthService>();
            mockService.Setup(service => service.IsBirdHealthy("1")).Returns(false);

            Form1.UpdateBirdAvailability(bird, mockService.Object);

            Assert.IsFalse(bird.AvailableForSale);
            mockService.Verify(service => service.IsBirdHealthy("1"), Times.Once);
        }

        private static List<Bird> CreateUnsortedBirds()
        {
            return new List<Bird>
            {
                new Bird("1", "תוכי", "Blue", 2020, "בבידוד", true),
                new Bird("2", "יונה", "Green", 2024, "בבידוד", true),
                new Bird("3", "נשר", "White", 2018, "בבידוד", true)
            };
        }

        private static List<Bird> CreateManyBirds(int count)
        {
            var random = new Random(1);
            var birds = new List<Bird>();

            for (int i = 0; i < count; i++)
            {
                birds.Add(new Bird(
                    i.ToString(),
                    "תוכי",
                    "Blue",
                    1900 + random.Next(127),
                    "בבית הגידול",
                    i % 2 == 0));
            }

            return birds;
        }

        private static void AssertYearsAreDescending(List<Bird> birds)
        {
            for (int i = 0; i < birds.Count - 1; i++)
            {
                Assert.IsGreaterThanOrEqualTo(
                    birds[i + 1].HatchYear,
                    birds[i].HatchYear,
                    "Birds should be sorted by hatch year descending.");
            }
        }
    }
}
