namespace ListIt_Maui.Models;

public static class ImageConstants
{
    public static readonly Dictionary<CategoryType, string> CategoryImageMap = new Dictionary<CategoryType, string>()
    {
        { CategoryType.Mercado, "ps_cart.png"},
        { CategoryType.Eletronicos, "computer_simbolo.png"},
        { CategoryType.Oficina, "ph_gear.png"},
        { CategoryType.Farmacia, "mdi_health.png"}
    };
}