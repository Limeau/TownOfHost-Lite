using TOHL.Roles.Core;
using UnityEngine;

namespace TOHL.Modules.OptionItems.Interfaces;

public interface IRoleOptionItem
{
    public CustomRoles RoleId { get; }
    public Color RoleColor { get; }
}
