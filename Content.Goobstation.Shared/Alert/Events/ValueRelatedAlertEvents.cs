// SPDX-FileCopyrightText: 2025 BombasterDS2 <bombasterds.github@mail.ru>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Alert;

namespace Content.Goobstation.Shared.Alert.Events;

[ByRefEvent]
public record struct GetValueRelatedAlertValuesEvent(AlertPrototype Alert, float? MaxValue = null, float? CurrentValue = null, float MinValue = 0)
{
    public bool Handled => MaxValue.HasValue && CurrentValue.HasValue;
}
