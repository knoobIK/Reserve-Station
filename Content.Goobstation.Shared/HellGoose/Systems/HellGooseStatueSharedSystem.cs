// SPDX-FileCopyrightText: 2025 JohnJohn <189290423+JohnJJohn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Shared.HellGoose.Components;
using Content.Shared.Verbs;
using Robust.Shared.Utility;

namespace Content.Goobstation.Shared.HellGoose.Systems;

public abstract class HellGooseStatueSharedSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<HellGooseStatueComponent, GetVerbsEvent<AlternativeVerb>>(OnGetVerbs);
    }

    private void OnGetVerbs(EntityUid uid, HellGooseStatueComponent comp, GetVerbsEvent<AlternativeVerb> args)
    {
        if (!args.CanAccess || !args.CanInteract)
            return;

        var verb = new AlternativeVerb()
        {
            Text = Loc.GetString("hell-goose-statue-accept"),
            Icon = new SpriteSpecifier.Texture(new ResPath("/Textures/Interface/pray.svg.png")),
            Act = () =>
            {
                PolymorphTheGoose(args.User);
            }
        };

        args.Verbs.Add(verb);
    }
    protected virtual void PolymorphTheGoose(EntityUid uid) {}
}
