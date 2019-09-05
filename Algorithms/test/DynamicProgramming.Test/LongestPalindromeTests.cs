namespace DynamicProgramming.Test
{
    using Xunit;
    using FluentAssertions;

    public class LongestPalindromeTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("z", "z")]
        [InlineData("bb", "bb")]
        [InlineData("eabcb", "bcb")]
        [InlineData("bbabbad", "bbabb")]
        [InlineData("forgeeksskeegfor", "geeksskeeg")]
        [InlineData("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth", "ranynar")]
        public void GetLongestPalindrome_ShouldReturn_TheLongestPalindromeInTheString(
            string input,
            string expectedOutput)
        {
            // Arrange
            var longestPalindrome = new LongestPalindrome();

            // Act
            var output = longestPalindrome.GetLongestPalindrome(input);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}
