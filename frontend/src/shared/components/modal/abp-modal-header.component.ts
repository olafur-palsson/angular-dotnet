import {
  Component,
  Input,
  Output,
  EventEmitter,
  ChangeDetectionStrategy,
  Injector
} from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'abp-modal-header',
  template: `
      <div class="modal-header">
          <h4 class="modal-title">{{ title }}</h4>
          <button
                  type="button"
                  class="close"
                  aria-label="Close"
                  (click)="onCloseClick.emit()">
              <span aria-hidden="true">&times;</span>
          </button>
      </div>
  `
})
export class AbpModalHeaderComponent extends AppComponentBase {
  @Input() title: string;
  @Output() onCloseClick = new EventEmitter<number>();
  constructor(injector: Injector) {
    super(injector);
  }
}
