import {NgModule} from "@angular/core";
import {SharedModule} from "../../shared/shared.module";
import {RouterLink, RouterLinkActive} from '@angular/router';
import {NgClass, NgIf} from '@angular/common';
import { OverviewComponent } from './overview/overview.component';
import { OpenJobsComponent } from './overview/open-jobs/open-jobs.component';
import { MyTasksComponent } from './overview/my-tasks/my-tasks.component';
import { ColleaguesTasksComponent } from './overview/colleagues-tasks/colleagues-tasks.component';
import { AllPartnerFilesComponent } from './overview/all-partner-files/all-partner-files.component';
import { OverviewService } from "src/app/services/overview.service";
import { JobDetailsComponent } from './overview/job-details/job-details.component';

@NgModule({
  declarations: [
    OverviewComponent,
    OpenJobsComponent,
    MyTasksComponent,
    ColleaguesTasksComponent,
    AllPartnerFilesComponent,
    JobDetailsComponent
  ],
  imports: [
    SharedModule
  ],
  exports: [

  ]
})
export class OverviewModule {}
