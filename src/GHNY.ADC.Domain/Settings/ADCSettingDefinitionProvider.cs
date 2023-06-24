using Volo.Abp.Settings;

namespace GHNY.ADC.Settings;

public class ADCSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ADCSettings.MySetting1));
    }
}
