namespace Phaeyz.Testing.Test;

internal class QuickTestTest
{
    [Test]
    public async Task ReturnString_BasicString_ReturnsBasicString()
    {
        QuickTest quickTest = new();
        await Assert.That(quickTest.ReturnString("test")).IsEqualTo("test");
    }
}
