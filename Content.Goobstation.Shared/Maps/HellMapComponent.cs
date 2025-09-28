// SPDX-FileCopyrightText: 2025 JohnJohn <189290423+JohnJJohn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

namespace Content.Goobstation.Shared.Maps;

/// <summary>
/// Component for Hell Map
/// </summary>
[RegisterComponent]
public sealed partial class HellMapComponent : Component
{
    [DataField] public EntityUid? ExitPortal;
}
