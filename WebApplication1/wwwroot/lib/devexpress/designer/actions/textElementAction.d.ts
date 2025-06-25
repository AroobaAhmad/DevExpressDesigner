﻿/**
* DevExpress HTML/JS Reporting (designer\actions\textElementAction.d.ts)
* Version:  24.1.3
* Build date: Jun 12, 2024
* Copyright (c) 2012 - 2024 Developer Express Inc. ALL RIGHTS RESERVED
* License: https://www.devexpress.com/Support/EULAs/universal.xml
*/
import { BaseActionsProvider, ISelectionProvider } from '@devexpress/analytics-core/analytics-internal';
export declare class TextElementAction extends BaseActionsProvider {
    private _selectionProvider;
    private get _textControls();
    private _inaccessibleAction;
    constructor(_selectionProvider: ISelectionProvider);
    condition(context: any): boolean;
}
