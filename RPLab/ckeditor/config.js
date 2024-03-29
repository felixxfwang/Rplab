﻿/*
Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
     //config.language = 'zh-cn';
    // config.uiColor = '#AADC6E';

    config.height = 700;
    config.toolbar_RplTool =
    [
    ['Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
    ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', 'Blockquote'],
    ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
    ['Link', 'Unlink', 'Anchor'],
    ['Image', 'addpic', 'Table', 'HorizontalRule'],
    ['Font', 'FontSize'],
    ['Maximize', 'ShowBlocks'],
    ['Source']
    ];
    config.extraPlugins = 'addpic';

};
