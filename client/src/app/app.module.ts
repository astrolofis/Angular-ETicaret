import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
<<<<<<< HEAD
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
<<<<<<< HEAD
=======
import {HttpClientModule} from '@angular/common/http';

>>>>>>> parent of 860be9a (Routing işlemleri/ hata ayıklama ve hata mesajları / yükleniyor ekranı / breadCrumb eklendi)
=======

>>>>>>> parent of e6e8d7d (hatalı bölüm)
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from './core/core.module';
import { ShopModule } from './shop/shop.module';
<<<<<<< HEAD
import { HomeModule } from './home/home.module';
import { ErrorInterceptor } from './core/interceptors/error.interceptor';
import { NgxSpinnerModule } from 'ngx-spinner';
import { LoadingInterceptor } from './core/interceptors/loading.interceptor';
=======
>>>>>>> parent of 860be9a (Routing işlemleri/ hata ayıklama ve hata mesajları / yükleniyor ekranı / breadCrumb eklendi)

@NgModule({
  declarations: [
    AppComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CoreModule,
<<<<<<< HEAD
    ShopModule,
    HomeModule,
    NgxSpinnerModule 
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS,useClass:ErrorInterceptor, multi:true  },
    {provide:HTTP_INTERCEPTORS,useClass:LoadingInterceptor, multi:true  }
=======
    ShopModule
>>>>>>> parent of 860be9a (Routing işlemleri/ hata ayıklama ve hata mesajları / yükleniyor ekranı / breadCrumb eklendi)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
