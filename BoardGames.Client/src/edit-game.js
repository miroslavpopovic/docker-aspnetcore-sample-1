import { ApiService } from './api-service';
import { inject } from 'aurelia-framework';

@inject(ApiService)
export class EditGame {
  constructor(api) {
    this.api = api;
  }

  activate() {
    
  }
}
