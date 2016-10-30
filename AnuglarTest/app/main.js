"use strict";
var platform_browser_dynamic_1 = require('@angular/platform-browser-dynamic');
var app_module_1 = require('./app.module');
var task_module_1 = require('./task.module');
var platform = platform_browser_dynamic_1.platformBrowserDynamic();
platform.bootstrapModule(app_module_1.AppModule);
platform.bootstrapModule(task_module_1.TaskModule);
//# sourceMappingURL=main.js.map