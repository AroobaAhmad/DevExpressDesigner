/**
* DevExpress HTML/JS Reporting (viewer\reportPreview.viewModel.js)
* Version:  24.1.3
* Build date: Jun 12, 2024
* Copyright (c) 2012 - 2024 Developer Express Inc. ALL RIGHTS RESERVED
* License: https://www.devexpress.com/Support/EULAs/universal.xml
*/
import { createViewModelGenerator } from '@devexpress/analytics-core/analytics-serializer-native';
export function createReportPreviewViewModel(base) {
    return createViewModelGenerator(base)
        .generateProperty('editingFieldsHighlighted', this.editingFieldsHighlighted)
        .generateProperty('rtlReport', this.rtlReport)
        .generateProperty('currentPage', this.currentPage?.getViewModel())
        .generateProperty('progressBar', this.progressBar?.getViewModel())
        .generateProperty('showMultipagePreview', this.showMultipagePreview)
        .generateProperty('previewVisible', this.previewVisible)
        .generateProperty('getSelectedContent', (mask) => this.getSelectedContent(mask))
        .generateProperty('lazyImagesOptions', {
        getEnabled: () => this.showMultipagePreview,
        setLoadVisibleImagesCallback: (callback) => {
            this._loadVisibleImages = callback;
            return () => {
                this._loadVisibleImages = null;
            };
        },
        getPage: (index) => {
            return this.pages[index];
        },
        setPageVisibility: (page, isVisible) => this.setPageVisibility(page.getModel(), isVisible)
    })
        .generateProperty('pages', this._getPagesViewModels())
        .generateProperty('delayedInit', () => this.delayedInit())
        .generateProperty('emptyDocumentCaption', this.emptyDocumentCaption)
        .generateProperty('previewBrickKeyboardHelper', this.previewBrickKeyboardHelper)
        .getViewModel();
}
export function updateReportPreviewViewModel(args) {
    const viewModel = this.getViewModel();
    if (args.propertyName === 'editingFieldsHighlighted') {
        viewModel.editingFieldsHighlighted = this.editingFieldsHighlighted;
    }
    if (args.propertyName === 'showMultipagePreview') {
        viewModel.showMultipagePreview = this.showMultipagePreview;
    }
    if (args.propertyName === 'rtlReport') {
        viewModel.rtlReport = this.rtlReport;
    }
    if (args.propertyName === 'emptyDocumentCaption') {
        viewModel.emptyDocumentCaption = this.emptyDocumentCaption;
    }
    if (args.propertyName === 'previewVisible') {
        viewModel.previewVisible = this.previewVisible;
    }
    if (args.propertyName === 'currentPage') {
        viewModel.currentPage = this.currentPage?.getViewModel();
    }
    if (args.propertyName === 'pages') {
        viewModel.pages = this._getPagesViewModels();
    }
    if (args.propertyName === 'signatures') {
        viewModel.signatures = this.signatures;
    }
}
