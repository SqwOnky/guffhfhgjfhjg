using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Omniverse.Projectiles;

namespace Omniverse.Content.Items.Weapons
{
    public class DarkStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Dark Star"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Pulses with energy from the Cosmos and the Corruption..." +
                "shoots 3 stars per swing.");
        }

        public override void SetDefaults()
        {
            Item.damage = 34;
            Item.DamageType = DamageClass.Melee;
            Item.width = 560;
            Item.height = 560;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 8;
            Item.value = 60000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<EvilStar>();
            Item.autoReuse = true;
            Item.shootSpeed = 18f;
            Item.scale = 1.7f;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}