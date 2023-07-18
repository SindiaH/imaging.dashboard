import { Component } from '@angular/core';
import { PageSettingsModel } from '@syncfusion/ej2-angular-grids';
import { ColleaguesTasks, OverviewService } from 'src/app/services/overview.service';
import { DestroySubscriptionsComponent } from 'src/app/shared/destroy-subscriptions/destroy-subscriptions.component';

@Component({
  selector: 'app-colleagues-tasks',
  templateUrl: './colleagues-tasks.component.html',
  styleUrls: ['./colleagues-tasks.component.scss']
})
export class ColleaguesTasksComponent extends DestroySubscriptionsComponent{
  colleaguesTasksList : ColleaguesTasks[] = [];
  pageSettings: PageSettingsModel;


  constructor(public overviewService : OverviewService) {
    super();
    overviewService.colleaguesTasks.subscribe((colleaguesTasks) => {
      this.colleaguesTasksList = colleaguesTasks
    })
    this.pageSettings = { pageSize : overviewService.pageSettings.pageSize}
    overviewService.loadColleaguesTasks();
  }
}