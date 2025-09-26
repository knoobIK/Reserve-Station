// SPDX-FileCopyrightText: 2024 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Rouden <149893554+Roudenn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 SX-7 <sn1.test.preria.2002@gmail.com>
// SPDX-FileCopyrightText: 2025 ScarKy0 <106310278+ScarKy0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 nazrin <tikufaev@outlook.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Alert;
using Robust.Client.GameObjects;

namespace Content.Client.Alerts;

/// <summary>
/// Event raised on an entity with alerts in order to allow it to update visuals for the alert sprite entity.
/// </summary>
[ByRefEvent]
public record struct UpdateAlertSpriteEvent
{
    public Entity<SpriteComponent> SpriteViewEnt;

    public EntityUid ViewerEnt;

    public AlertPrototype Alert;

    public UpdateAlertSpriteEvent(Entity<SpriteComponent> spriteViewEnt, EntityUid viewerEnt, AlertPrototype alert)
    {
        SpriteViewEnt = spriteViewEnt;
        ViewerEnt = viewerEnt;
        Alert = alert;
    }
}