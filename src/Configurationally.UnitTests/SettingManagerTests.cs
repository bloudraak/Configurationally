#region Copyright

// The MIT License (MIT)
// 
// Copyright (c) 2014 Werner Strydom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

namespace Configurationally
{
    using NUnit.Framework;

    /// <summary>
    /// Represents unit tests for <see cref="SettingManager"/>
    /// </summary>
    [TestFixture]
    public class SettingManagerTests
    {
        /// <summary>
        /// Verifies the default constructor of <see cref="SettingManager"/>
        /// </summary>
        [Test]
        public void Settings()
        {
            // Arrange
            SettingManager target;

            // Act
            target = new SettingManager();

            // Assert
            Assert.IsNotNull(target.Settings, "The default constructor did not initialize the settings collection");
            Assert.IsEmpty(target.Settings, "The default constructor added settings, which is not expected");
        }
    }
}