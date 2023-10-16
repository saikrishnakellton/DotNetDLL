"use strict";(self.webpackChunkberry_free_material_react_cra=self.webpackChunkberry_free_material_react_cra||[]).push([[566],{6566:function(e,t,s){s.r(t),s.d(t,{default:function(){return $}});var l=s(2791),a=s(8687),i=s(1889),n=s(8550),r=s(7198),o=s(3786),h=s(7071),d=s(6151),c=s(6999),p=s(8096),u=s(4925),x=s(9673),g=s(184);class m extends l.Component{constructor(e){super(e),this.handleClearFiles=()=>{this.setState({selectedFiles:[]}),this.fileInputRef.current&&(this.fileInputRef.current.value="")},this.handleDateChange=e=>{const{value:t}=e.target;this.props.updateAnyState({error_files:[]}),this.props.updateFileDate(t),this.props.fetchTotalRecords(t),this.props.fetchFileDetails(t),this.handleClearFiles()},this.handleCategoryChange=e=>{this.setState({category:e.target.value})},this.handleFileChange=e=>{this.props.updateAnyState({error_files:[]});const t=e.target.files,s=Array.from(t);if(s.filter((e=>{const t=e.name.split(".");return"zip"===t[t.length-1].toLowerCase()})).length>1)return this.setState({errorMessage:"Only one zip file allowed."}),void this.handleClearFiles();this.setState({errorMessage:""}),this.setState({selectedFiles:s})},this.handleUpload=()=>{this.props.updateAnyState({error_files:[]});const{category:e,selectedFiles:t}=this.state;this.props.operationDate&&e&&0!==t.length?(this.props.uploadFiles(this.props.operationDate,e,t),this.handleClearFiles()):this.setState({errorMessage:"Please fill in all the mandatory fields and select at least one file."})},this.state={category:"Aramco D&WO Morning Report",selectedFiles:[],errorMessage:""},this.fileInputRef=l.createRef()}render(){const{category:e,selectedFiles:t,errorMessage:s}=this.state,{operationDate:l,loading:a,error_files:c}=this.props;return(0,g.jsx)("div",{children:(0,g.jsxs)(i.ZP,{container:!0,spacing:2,children:[(0,g.jsx)(i.ZP,{item:!0,xs:12,children:(0,g.jsx)(n.Z,{sx:{m:1,width:300},label:"Operation Date",type:"date",value:l,onChange:this.handleDateChange,InputLabelProps:{shrink:!0}})}),(0,g.jsx)(i.ZP,{item:!0,xs:12,children:(0,g.jsxs)(p.Z,{sx:{m:1,width:300},children:[(0,g.jsx)(u.Z,{id:"category",children:"Category"}),(0,g.jsx)(r.Z,{value:e,label:"Category",onChange:this.handleCategoryChange,style:{minWidth:"300px"},id:"category",children:(0,g.jsx)(o.Z,{value:"Aramco D&WO Morning Report",children:"Aramco D&WO Morning Report"})})]})}),(0,g.jsxs)(i.ZP,{item:!0,xs:12,children:[(0,g.jsx)("input",{type:"file",accept:".html,.zip",multiple:!0,onChange:this.handleFileChange,ref:this.fileInputRef}),t.length>0&&(0,g.jsxs)("div",{children:["Selected Files:",(0,g.jsx)("ul",{style:{maxHeight:"200px",overflow:"auto"},children:t.map(((e,t)=>(0,g.jsx)("li",{children:e.name},t)))})]}),s&&(0,g.jsx)(h.Z,{error:!0,children:s})]}),0!=c.length&&(0,g.jsxs)(i.ZP,{item:!0,xs:12,children:["Files Failed to Upload due to duplicates:",(0,g.jsx)("div",{style:{maxHeight:"200px",overflow:"auto"},children:c.map(((e,t)=>(0,g.jsx)(h.Z,{error:!0,children:e},t)))})]}),(0,g.jsx)(i.ZP,{item:!0,xs:12,children:(0,g.jsx)(d.Z,{variant:"contained",style:{background:"#5e35b1"},onClick:this.handleUpload,children:"Upload"})})]})})}}const j={uploadFiles:x.IL,fetchFileDetails:x.MU,updateFileDate:x.at,fetchTotalRecords:x.S4,updateAnyState:x.K6};var f=(0,a.$j)((e=>({loading:e.upload.loading,operationDate:e.upload.operationDate,error_files:e.upload.error_files})),j)(m),C=s(9201),F=(0,C.Z)((0,g.jsx)("path",{d:"M7 14H5v5h5v-2H7v-3zm-2-4h2V7h3V5H5v5zm12 7h-3v2h5v-5h-2v3zM14 5v2h3v3h2V5h-5z"}),"Fullscreen");class Z extends l.Component{constructor(e){super(e),this.handleToggleFullScreen=()=>{this.setState((e=>({isFullScreen:!e.isFullScreen})));const e=document.getElementById("htmlContent");e&&(e.requestFullscreen?document.fullscreenElement?document.exitFullscreen():e.requestFullscreen():e.mozRequestFullScreen?document.mozFullScreenElement?document.mozCancelFullScreen():e.mozRequestFullScreen():e.webkitRequestFullscreen?document.webkitFullscreenElement?document.webkitExitFullscreen():e.webkitRequestFullscreen():e.msRequestFullscreen&&(document.msFullscreenElement?document.msExitFullscreen():e.msRequestFullscreen()))},this.state={isFullScreen:!1}}render(){const{loading:e,htmlContent:t,updateViewFIle:s}=this.props;return(0,g.jsxs)("div",{children:[(0,g.jsxs)("h3",{children:["File Name: ",e?"Loading...":s.split("\\")[4]]}),(0,g.jsx)("button",{onClick:this.handleToggleFullScreen,children:(this.state.isFullScreen,(0,g.jsx)(F,{}))}),(0,g.jsx)("iframe",{src:`data:text/html;charset=utf-8,${encodeURIComponent(t)}`,title:"External HTML Content",id:"htmlContent",style:{border:"none",width:"100%",height:"1000px",backgroundColor:"#fff"}})]})}}var v=(0,a.$j)((e=>({loading:e.upload.loading,htmlContent:e.upload.htmlContent,updateViewFIle:e.upload.updateViewFIle})),{})(Z),y=s(9281),w=s(5527),D=s(9836),S=s(6890),b=s(5855),P=s(3994),R=s(3382),_=s(6812),k=s(4082),M=s(4554),I=s(890),O=s(5397),A=(0,C.Z)((0,g.jsx)("path",{d:"M12 4.5C7 4.5 2.73 7.61 1 12c1.73 4.39 6 7.5 11 7.5s9.27-3.11 11-7.5c-1.73-4.39-6-7.5-11-7.5zM12 17c-2.76 0-5-2.24-5-5s2.24-5 5-5 5 2.24 5 5-2.24 5-5 5zm0-8c-1.66 0-3 1.34-3 3s1.34 3 3 3 3-1.34 3-3-1.34-3-3-3z"}),"Visibility"),z=(0,C.Z)((0,g.jsx)("path",{d:"M19 9h-4V3H9v6H5l7 7 7-7zM5 18v2h14v-2H5z"}),"GetApp"),V=s(3708),N=s(5985);class U extends l.Component{constructor(e){super(e),this.handleSearchQueryChange=e=>{this.props.updateAnyState({searchQuery:e.target.value})},this.handleSearchOptionChange=e=>{this.props.updateAnyState({searchOption:e.target.value})},this.handleSearch=()=>{this.props.updateAnyState({page:0}),this.props.fetchTotalRecords(),this.props.fetchFileDetails()},this.handleChangePage=(e,t)=>{this.props.updateAnyState({page:t}),this.props.fetchFileDetails()},this.handleChangeRowsPerPage=e=>{const t=parseInt(e.target.value,10);this.props.updateAnyState({rowsPerPage:t,page:0}),this.props.fetchFileDetails()},this.handleDelete=e=>{this.setState({deleteFileId:e,isDeleteModalOpen:!0})},this.handleConfirmDelete=()=>{const{deleteFileId:e}=this.state;1==this.props.fileDetails.length&&0!=this.props.page&&this.props.updateAnyState({page:this.props.page-1}),this.props.deleteFile(e),this.setState({deleteFileId:null,isDeleteModalOpen:!1})},this.handleCancelDelete=()=>{this.setState({deleteFileId:null,isDeleteModalOpen:!1})},this.handleView=e=>{this.props.updateViewFIle(e)},this.handleDownload=e=>{fetch(`${V.A}/api/download?file_name=${encodeURIComponent(e)}`).then((e=>{if(e.ok)return e.blob();throw N.Am.error("Error downloading file",{position:"top-right",autoClose:5e3,hideProgressBar:!1,closeOnClick:!0,pauseOnHover:!0,draggable:!0,progress:void 0,theme:"light"}),new Error("Error downloading file")})).then((t=>{const s=URL.createObjectURL(t),l=document.createElement("a");l.href=s,l.download=e.split("\\")[4],l.click(),URL.revokeObjectURL(s)})).catch((e=>{console.error(e)}))},this.state={deleteFileId:null,isDeleteModalOpen:!1}}componentDidMount(){this.props.fetchTotalRecords(),this.props.fetchFileDetails()}render(){const{fileDetails:e,loading:t,totalRecords:s,page:l,rowsPerPage:a,searchQuery:i,searchOption:h}=this.props,{isDeleteModalOpen:c}=this.state;return e?(0,g.jsxs)("div",{children:[(0,g.jsx)("h2",{children:"File Details"}),(0,g.jsxs)("div",{children:[(0,g.jsxs)(p.Z,{sx:{m:1,width:300},children:[(0,g.jsx)(u.Z,{id:"search-option-file",children:"Select Parameter"}),(0,g.jsxs)(r.Z,{value:h,onChange:this.handleSearchOptionChange,style:{minWidth:"300px"},label:"Select Parameter",id:"search-option-file",children:[(0,g.jsx)(o.Z,{value:"rig_name",children:"RIG Name"}),(0,g.jsx)(o.Z,{value:"well_name",children:"Well Name"}),(0,g.jsx)(o.Z,{value:"file_path",children:"File Name"})]})]}),(0,g.jsxs)(p.Z,{sx:{m:1,width:300},children:[(0,g.jsx)(u.Z,{id:"search-query"}),(0,g.jsx)(n.Z,{type:"text",id:"search-query",value:i,onChange:this.handleSearchQueryChange,label:"Search"})]}),(0,g.jsx)(d.Z,{variant:"contained",style:{background:"#5e35b1",padding:"11px",width:"100px",margin:"11px"},onClick:this.handleSearch,children:"Search"})]}),(0,g.jsx)("br",{}),(0,g.jsx)(y.Z,{component:w.Z,children:(0,g.jsxs)(D.Z,{children:[(0,g.jsx)(S.Z,{children:(0,g.jsxs)(b.Z,{children:[(0,g.jsx)(P.Z,{children:"Actions"}),(0,g.jsx)(P.Z,{children:"Operation Date"}),(0,g.jsx)(P.Z,{children:"RIG Name"}),(0,g.jsx)(P.Z,{children:"Well Name"}),(0,g.jsx)(P.Z,{children:"File Name"})]})}),(0,g.jsx)(R.Z,{children:e.map((e=>(0,g.jsxs)(b.Z,{children:[(0,g.jsx)(P.Z,{children:(0,g.jsxs)("div",{style:{display:"flex"},children:[(0,g.jsx)(d.Z,{onClick:()=>this.handleDelete(e._id),sx:{padding:.5,margin:0,minWidth:"unset"},children:(0,g.jsx)(O.Z,{color:"error"})}),(0,g.jsx)(d.Z,{onClick:()=>this.handleView(e.file_path),sx:{padding:.5,margin:0,minWidth:"unset"},children:(0,g.jsx)(A,{style:{color:"#5e35b1"}})}),(0,g.jsx)(d.Z,{onClick:()=>this.handleDownload(e.file_path),sx:{padding:.5,margin:0,minWidth:"unset"},children:(0,g.jsx)(z,{color:"success"})})]})}),(0,g.jsx)(P.Z,{children:e.created_at}),(0,g.jsx)(P.Z,{children:e.rig_name}),(0,g.jsx)(P.Z,{children:e.well_name}),(0,g.jsx)(P.Z,{children:e.file_name})]},e._id)))})]})}),(0,g.jsx)(_.Z,{rowsPerPageOptions:[5,10,25,50,100,500],component:"div",rowsPerPage:a,page:l,onPageChange:this.handleChangePage,onRowsPerPageChange:this.handleChangeRowsPerPage,count:s}),(0,g.jsx)(k.Z,{open:c,onClose:this.handleCancelDelete,children:(0,g.jsxs)(M.Z,{sx:{position:"absolute",top:"50%",left:"50%",transform:"translate(-50%, -50%)",width:400,bgcolor:"background.paper",boxShadow:24,p:4},children:[(0,g.jsx)(I.Z,{variant:"h6",children:"Confirm Delete"}),(0,g.jsx)(I.Z,{variant:"body1",children:"Are you sure you want to delete this file?"}),(0,g.jsx)(d.Z,{onClick:this.handleConfirmDelete,children:"Yes"}),(0,g.jsx)(d.Z,{onClick:this.handleCancelDelete,children:"No"})]})})]}):(0,g.jsx)("p",{children:"No file details available."})}}const q={fetchFileDetails:x.MU,deleteFile:x._I,updateViewFIle:x.h6,fetchTotalRecords:x.S4,updateAnyState:x.K6};var E=(0,a.$j)((e=>({fileDetails:e.upload.fileDetails,loading:e.upload.loading,operationDate:e.upload.operationDate,totalRecords:e.upload.totalRecords,page:e.upload.page,rowsPerPage:e.upload.rowsPerPage,searchQuery:e.upload.searchQuery,searchOption:e.upload.searchOption})),q)(U),H=s(2007),L=s.n(H),W=s(6286);class T extends l.Component{render(){return(0,g.jsxs)("div",{children:[this.props.loading&&(0,g.jsx)("div",{className:"loader-container",children:(0,g.jsx)(W.Nx,{width:"200",color:"#5e35b1",ariaLabel:"loading",wrapperStyle:!0,wrapperClass:!0})}),(0,g.jsxs)(i.ZP,{container:!0,spacing:2,children:[(0,g.jsx)(i.ZP,{item:!0,xs:12,sm:12,md:this.props.htmlContent?5:12,children:(0,g.jsxs)(c.Z,{className:"card",children:[(0,g.jsx)("h1",{children:"Daily Document Upload"}),(0,g.jsx)(f,{}),(0,g.jsx)(E,{})]})}),this.props.htmlContent&&(0,g.jsx)(i.ZP,{item:!0,xs:12,sm:12,md:7,children:(0,g.jsx)(c.Z,{className:"card",children:(0,g.jsx)(v,{})})})]})]})}}v.propTypes={loading:L().bool.isRequired,htmlContent:L().func.isRequired};var $=(0,a.$j)((e=>({loading:e.upload.loading,htmlContent:e.upload.htmlContent})),{})(T)},5397:function(e,t,s){var l=s(9201),a=s(184);t.Z=(0,l.Z)((0,a.jsx)("path",{d:"M6 19c0 1.1.9 2 2 2h8c1.1 0 2-.9 2-2V7H6v12zM19 4h-3.5l-1-1h-5l-1 1H5v2h14V4z"}),"Delete")}}]);
//# sourceMappingURL=566.7483e3a1.chunk.js.map