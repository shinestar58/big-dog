using STS2RitsuLib.Scaffolding.Content;

namespace BigDog.Scripts;

public class BigDogRelicPool : TypeListRelicPoolModel
{
    // 描述中使用的能量图标。大小为24x24。
    public override string? TextEnergyIconPath => "res://BigDog/images/energy/energy_big_dog.png";
    // tooltip和卡牌左上角的能量图标。大小为74x74。
    public override string? BigEnergyIconPath => "res://BigDog/images/energy/energy_big_dog_big.png";

    public override string EnergyColorName => "BigDog";
}