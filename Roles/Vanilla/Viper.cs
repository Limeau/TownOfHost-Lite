using AmongUs.GameOptions;
using TOHL.Roles.Core;
using TOHL.Roles.Core.Interfaces;

namespace TOHL.Roles.Vanilla;

public sealed class Viper : RoleBase, IImpostor
{
    public Viper(PlayerControl player) : base(RoleInfo, player) { }
    public static readonly SimpleRoleInfo RoleInfo = SimpleRoleInfo.CreateForVanilla(typeof(Viper), player => new Viper(player), RoleTypes.Viper);
}
