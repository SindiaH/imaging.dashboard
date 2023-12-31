import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import {BaseModule} from "./modules/base/base.module";
import {AppRoutingModule} from "./app-routing.module";
import {environment} from '../environments/environment';
import {API_BASE_URL} from './core/NSwagDataClient';
import {FetchDataService} from './services/fetch-data.service';
import { GridModule, PagerModule, PageService, SortService, FilterService, DetailRowService } from '@syncfusion/ej2-angular-grids';
import { OverviewModule } from './modules/overview/overview.module';
import { OverviewService } from './services/overview.service';
/*import buttons*/
import { DropDownButtonModule, SplitButtonModule } from '@syncfusion/ej2-angular-splitbuttons';
import { ArchiveService } from './services/archive.service';
import { ButtonModule } from '@syncfusion/ej2-angular-buttons';
import { AdministrationService } from './services/administration.service';
import { StatusService } from './services/status.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    HttpClientModule,
    FormsModule,
    BaseModule,
    AppRoutingModule,
    BrowserModule,
    GridModule,
    SplitButtonModule,
    DropDownButtonModule
  ],
  providers: [
    HttpClientModule,
    FetchDataService,
    {
      provide: API_BASE_URL,
      useValue: environment.apiRoot
    },
    OverviewService,
    PageService,
    SortService,
    FilterService,
    ArchiveService,
    AdministrationService,
    DetailRowService,
    StatusService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
