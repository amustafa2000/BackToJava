import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app.module';
import { TaskModule } from './task.module';
const platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);
platform.bootstrapModule(TaskModule);