namespace AspNetSampleMvcApp.ConfigurationProviders;

public static class TextConfigurationExtenstion
{
    public static IConfigurationBuilder AddTextFile(this IConfigurationBuilder builder, string path)
    {
        var source = new TxtConfigurationSource(path);
        builder.Add(source);
        return builder;
    }
}