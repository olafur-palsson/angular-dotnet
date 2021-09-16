import { Component, Injector } from '@angular/core';

@Component({
  selector: 'account-footer',
  template: `
      <div class="row">
          <div class="col-md-12 text-center">
              <small>
                  Copyright &copy; {{ currentYear }}
                  <b class="ml-2">{{ "Version" | localize }}</b>
                  {{ versionText }}
              </small>
          </div>
      </div>
  `
})
export class Footer {
  currentYear: number;
  versionText: string;

  constructor(injector: Injector) {
    this.currentYear = new Date().getFullYear();
    this.versionText = '1'
  }
}
