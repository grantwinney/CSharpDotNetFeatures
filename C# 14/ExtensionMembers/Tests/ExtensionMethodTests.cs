using Helpers.ExtensionMethods;

namespace Tests;

public class ExtensionMethodTests
{
    [Test]
    [TestCase("", "")]
    [TestCase("A post.", "A post.")]
    [TestCase("Here we go again, with another .NET release.", "Here we go...")]
    public void ExcerptTests(string input, string expectedExcerpt)
    {
        Assert.That(input.ToExcerpt(10), Is.EqualTo(expectedExcerpt));
    }

    [Test]
    [TestCase("a b c", "a-b-c")]
    [TestCase("using new extension members", "using-new-extension-members")]
    public void SlugTests(string input, string expectedSlug)
    {
        Assert.That(input.ToSlug(), Is.EqualTo(expectedSlug));
    }

    [Test]
    [TestCase("", "")]
    [TestCase("a b c", "A B C")]
    [TestCase("using new extension members", "Using New Extension Members")]
    public void TitleCaseTests(string input, string expectedTitle)
    {
        Assert.That(input.ToTitleCase(), Is.EqualTo(expectedTitle));
    }
}
